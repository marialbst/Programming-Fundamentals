using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = CreateTeams();
            AddMembersToTeams(teams);

            PrintResults(teams);

        }

        private static void PrintResults(Dictionary<string, Team> teams)
        {   //подредени по бр. членове, после по име на отбора
            foreach (var team in teams.OrderByDescending(x => x.Value.Members.Count).ThenBy(x=>x.Key)) //x.Key = teamName
            {
                if (team.Value.Members.Count > 0)
                {
                    Console.WriteLine(team.Key);
                    Console.WriteLine($"- {team.Value.Creator}");
                    Console.WriteLine($"-- {string.Join("\r\n-- ", team.Value.Members.OrderBy(x=>x))}");
                                                                        //чл. подредени по азбучен ред

                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.OrderBy(x => x.Key)) 
            {
                if (team.Value.Members.Count == 0)
                {
                    Console.WriteLine($"{team.Key}");
                }
            }
        }

        private static void AddMembersToTeams(Dictionary<string, Team> teams)
        {
            string command = Console.ReadLine();

            while (!command.Equals("end of assignment"))
            {
                string[] memberJoins = command.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string member = memberJoins[0];
                string teamName = memberJoins[1];

                if (!teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    if (teams.Values.Any(x => x.Members.Contains(member)) || teams.Values.Any(x => x.Creator == member))
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    }
                    else
                    {

                        teams[teamName].Members.Add(member);
                        //Console.WriteLine($"{member} joins team {teamName}");  
                    }
                }

                command = Console.ReadLine();
            }
        }

        private static Dictionary<string, Team> CreateTeams()
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            int teamNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamNumbers; i++)
            {
                string[] teamsData = Console.ReadLine().Split('-');

                string creator = teamsData[0];
                string teamName = teamsData[1];

                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else
                {
                    if (teams.Values.Any(x => x.Creator == creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                    else
                    {
                        teams.Add(teamName, new Team());
                        teams[teamName].Creator = creator;
                        teams[teamName].TeamName = teamName;
                        teams[teamName].Members = new List<string>();
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                }
            }

            return teams;
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}