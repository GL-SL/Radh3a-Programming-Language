namespace RD3LanguageInterpreter.Interpreter.Instructions
{
    public abstract class BaseInstruction
    {
        public abstract void Interpret(InterpreterState state);

        public int Id { get; set; }
    }
}