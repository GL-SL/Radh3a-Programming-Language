using System;
using RD3LanguageInterpreter.Interpreter;
using RD3LanguageInterpreter.Interpreter.Instructions;

namespace RD3LanguageInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var expressionManager = new InstructionSequence();

            var rd3s = Radh3aParser.Parse(@"D:\radh3a.txt");

            foreach (var rd3 in rd3s)
            {
                if (rd3 == "rd3.rd3?") 
                    expressionManager.Add(new MovePointerForwardInstruction());
                else if (rd3 == "rd3?rd3.") 
                    expressionManager.Add(new MovePointerBackwardInstruction());
                else if (rd3 == "rd3.rd3.") 
                    expressionManager.Add(new IncrementCellInstruction());
                else if (rd3 == "rd3!rd3!") 
                    expressionManager.Add(new DecrementCellInstruction());
                else if (rd3 == "rd3.rd3!")
                    expressionManager.Add(new ReadCharInstruction());
                else if (rd3 == "rd3!rd3.")
                    expressionManager.Add(new PrintCharInstruction());
                else if (rd3 == "rd3!rd3?")
                    expressionManager.Add(new MoveForwardToWhenZeroInstruction(expressionManager));
                else if (rd3 == "rd3?rd3!")
                    expressionManager.Add(new MoveBackwardToIfNotZeroInstruction(expressionManager));
            }

            expressionManager.Run();

            Console.ReadLine();
        }
    }
}
