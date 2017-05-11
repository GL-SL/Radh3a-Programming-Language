using System;

namespace RD3LanguageInterpreter.Interpreter
{
    public class InterpreterState
    {
        private readonly int[] _memory = new int[100000];

        public InterpreterState()
        {
            Index = 0;
        }

        public int Index { get; private set; }

        public int CurrentData
        {
            get { return _memory[Index]; }
        }

        public void MoveNext()
        {
            Index++;
        }

        public void MovePrevious()
        {
            if ( Index==0)
                throw new Exception("Out of bound");
            Index--;
        }

        public void IncrementCurrentData()
        {
            _memory[Index]++;
        }

        public void DecrementCurrentData()
        {
            _memory[Index]--;
        }

        public void SetCurrentValue(byte data)
        {
            _memory[Index] = data;
        }
    }
}