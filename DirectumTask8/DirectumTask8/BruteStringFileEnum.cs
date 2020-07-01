using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DirectumTask8
{
    class BruteStringFileEnum : IEnumerator<string>
    {
        private List<string> Str;
        int position = -1;

        public BruteStringFileEnum(List<string> Str)
        {
            this.Str = Str;
        }

        public string Current
        {
            get
            {
                return this.Str[this.position];
            }
        }

        object IEnumerator.Current => this.Current;

        public bool MoveNext()
        {
            this.position++;
            if (this.position < Str.Count)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.position = -1;
        }
        public void Dispose() { }
    }
}
