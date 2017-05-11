namespace RD3LanguageInterpreter.Interpreter.Instructions
{
    public class MovePointerForwardInstruction : BaseInstruction
    {
        public override void Interpret(InterpreterState state)
        {
            state.MoveNext();
        }
    }
}