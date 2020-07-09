using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DirectumTask6
{
    class LoadFileException : IOException
    {
        public LoadFileException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
