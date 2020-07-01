namespace DirectumTask8
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="BruteStringsFile" />.
    /// </summary>
    internal class BruteStringsFile : IEnumerable<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BruteStringsFile"/> class.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        public BruteStringsFile(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                this.Collection = new List<string>();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    this.Collection.Add(line);
                }
            }
        }

        /// <summary>
        /// Gets the Collection.
        /// </summary>
        public List<string> Collection { get; }

        /// <summary>
        /// The GetEnumerator.
        /// </summary>
        /// <returns>The <see cref="IEnumerator{string}"/>.</returns>
        public IEnumerator<string> GetEnumerator()
        {
            return new BruteStringFileEnum(this.Collection);
        }

        /// <summary>
        /// The GetEnumerator.
        /// </summary>
        /// <returns>The <see cref="IEnumerator"/>.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Collection.GetEnumerator();
        }
    }
}
