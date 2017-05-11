namespace RD3LanguageInterpreter.Interpreter.Instructions
{
    public class MoveBackwardToIfNotZeroInstruction : BaseInstruction
    {
        private readonly InstructionSequence _instructionSequence;

        public MoveBackwardToIfNotZeroInstruction( InstructionSequence instructionSequence)
        {
            _instructionSequence = instructionSequence;
        }

        public override void Interpret(InterpreterState state)
        {
            if ( state.CurrentData !=  0)
                _instructionSequence.MoveBackBefore(typeof(MoveForwardToWhenZeroInstruction));
        }
    }
}