namespace DirectumTask3.Task4
{
    using System;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="Logger" />.
    /// </summary>
    internal class Logger : IDisposable
    {
        /// <summary>
        /// Defines the logFile.
        /// </summary>
        private FileStream logFile;

        /// <summary>
        /// Defines the logWriter.
        /// </summary>
        private StreamWriter logWriter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string"/>.</param>
        public Logger(string fileName)
        {
            this.logFile = new FileStream(fileName, FileMode.Append);
            this.logWriter = new StreamWriter(this.logFile);
            this.Dispose();
        }

        /// <summary>
        /// The WriteString.
        /// </summary>
        /// <param name="data">The data<see cref="string"/>.</param>
        public void WriteString(string data)
        {
            this.logWriter.WriteLine(data);
        }

        /// <summary>
        /// The Dispose.
        /// </summary>
        public void Dispose()
        {
            this.logFile?.Dispose();
            this.logWriter?.Dispose();
        }
    }
}
