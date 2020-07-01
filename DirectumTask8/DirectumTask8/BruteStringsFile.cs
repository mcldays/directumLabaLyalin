using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DirectumTask8
{
    class BruteStringsFile : IEnumerable<string>
    {
        public List<string> Str { get; }

        public BruteStringsFile(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                this.Str = new List<string>();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    this.Str.Add(line);
                }
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new BruteStringFileEnum(this.Str);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Str.GetEnumerator();
        }
    }
}
