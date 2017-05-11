using System;
using System.Collections.Generic;
using RD3LanguageInterpreter.Interpreter.Instructions;

namespace RD3LanguageInterpreter.Interpreter
{
    public class InstructionSequence
    {
        readonly List<BaseInstruction> _expressions = new List<BaseInstruction>();
        public void Add(BaseInstruction instruction)
        {
            _expressions.Add(instruction);
        }

        private int _instructionIndex;
        public void Run()
        {
            var state = new InterpreterState();

            while(_expressions.Count > _instructionIndex)
            {
                _expressions[_instructionIndex].Interpret(state);
                _instructionIndex++;
            }
        }

        public void MovePast(Type instructionType) 
        {
            while ( true )
            {
                var expression = _expressions[++_instructionIndex];
                if (instructionType == expression.GetType())
                    break;
            }
        }

        public void MoveBackBefore(Type instructionType)
        {
            while (true)
            {
                var expression = _expressions[--_instructionIndex];
                if (instructionType == expression.GetType())
                    break;
            }
        }
    }
}