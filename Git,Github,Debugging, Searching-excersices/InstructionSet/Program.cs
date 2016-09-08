using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = Console.ReadLine();
        decimal result = 0;

        while (opCode.ToLower() != "end")
        {
            string[] codeArgs = opCode.Split(' ');

            
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        operandOne++;
                        result = operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        operandOne--;
                        result = operandOne;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        decimal operandTwo = decimal.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }
            opCode = Console.ReadLine();
            Console.WriteLine(result);
        }
       
    }
}
