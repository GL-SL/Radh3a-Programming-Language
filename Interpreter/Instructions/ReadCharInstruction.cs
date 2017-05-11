using System;
using System.Text;

namespace RD3LanguageInterpreter.Interpreter.Instructions
{
    public class ReadCharInstruction : BaseInstruction
    {
        public override void Interpret(InterpreterState state)
        {
            char ch = Console.ReadKey().KeyChar;
            state.SetCurrentValue(Encoding.ASCII.GetBytes(new[] { ch })[0]);
        }
    }
}