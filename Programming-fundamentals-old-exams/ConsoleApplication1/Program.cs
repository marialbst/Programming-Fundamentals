using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main()
        {
            List<Team> allTeams = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                Team team = new Team();

                if (allTeams.Count > 0)
                {
                    bool isTrue = true;
                    //Check if team exist.
                    foreach (Team crw in allTeams)
                    {
                        if (crw.TeamName == input[1])
                        {
                            Console.WriteLine($"Team {input[1]} was already created!");
                            isTrue = false;
                        }
                    }
                    //Check if Teamleader exist
                    foreach (Team crw in allTeams)
                    {
                        if (crw.CreatorName == input[0])
                        {
                            Console.WriteLine($"{input[0]} cannot create another team!");
                            isTrue = false;
                        }
                    }
                    //Create a new team
                    if (isTrue)
                    {
                        team.CreatorName = input[0];
                        team.TeamName = input[1];
                        team.Members = new List<string>();
                        allTeams.Add(team);
                        Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                    }
                }
                else
                {
                    //Create new team
                    team.CreatorName = input[0];
                    team.TeamName = input[1];
                    team.Members = new List<string>();
                    allTeams.Add(team);
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                }
            }
            while (true)
            {
                string[] inputUsers = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (inputUsers[0] == "end of assignment")
                {
                    List<Team> ok = new List<Team>();
                    List<Team> off = new List<Team>();
                    foreach (Team teamFilter in allTeams)
                    {
                        if (teamFilter.Members.Count == 0)
                        {
                            off.Add(teamFilter);
                        }
                        else
                        {
                            ok.Add(teamFilter);
                        }
                    }
                    foreach (Team t in ok.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
                    {
                        Console.WriteLine(t.TeamName);
                        Console.WriteLine($"- {t.CreatorName}");
                        foreach (string person in t.Members.OrderBy(x => x))
                        {
                            Console.WriteLine($"-- {person}");
                        }
                    }
                    Console.WriteLine("Teams to disband:");
                    if (off.Count > 0)
                    {
                        for (int i = 0; i < off.Count; i++)
                        {
                            Console.WriteLine(off[i].TeamName);
                        }
                    }
                    break;
                }
                else
                {
                    bool isTeamExist = false;
                    bool isMemberExist = false;
                    foreach (Team crwTeam in allTeams)
                    {
                        if (crwTeam.TeamName == inputUsers[1])
                        {
                            isTeamExist = true;
                            for (int i = 0; i < allTeams.Count; i++)
                            {
                                if (inputUsers[0] == allTeams[i].CreatorName)
                                {
                                    isMemberExist = true;
                                }
                                else
                                {
                                    foreach (string member in allTeams[i].Members)
                                    {
                                        if (member == inputUsers[0])
                                        {
                                            isTeamExist = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!isTeamExist)
                    {
                        Console.WriteLine($"Team {inputUsers[1]} does not exist!");
                    }
                    if (isMemberExist)
                    {
                        Console.WriteLine($"Member {inputUsers[0]} cannot join team {inputUsers[1]}!");
                    }
                    if (isTeamExist && !isMemberExist)
                    {
                        for (int i = 0; i < allTeams.Count; i++)
                        {
                            if (allTeams[i].TeamName == inputUsers[1])
                            {
                                allTeams[i].Members.Add(inputUsers[0]);
                            }
                        }
                    }
                }
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }
    }
}