namespace RD3LanguageInterpreter.Interpreter.Instructions
{
    public class MoveForwardToWhenZeroInstruction: BaseInstruction
    {
        private readonly InstructionSequence _instructionSequence;

        public MoveForwardToWhenZeroInstruction(InstructionSequence instructionSequence)
        {
            _instructionSequence = instructionSequence;
        }

        public override void Interpret(InterpreterState state)
        {
            if ( state.CurrentData ==  0)
                _instructionSequence.MovePast(typeof(MoveBackwardToIfNotZeroInstruction));
        }
         
    }
}