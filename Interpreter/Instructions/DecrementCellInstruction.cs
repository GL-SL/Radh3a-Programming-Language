namespace RD3LanguageInterpreter.Interpreter.Instructions
{
    public class DecrementCellInstruction : BaseInstruction
    {
        public override void Interpret(InterpreterState state)
        {
            state.DecrementCurrentData();
        }
    }
}