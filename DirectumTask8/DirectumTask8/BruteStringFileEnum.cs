namespace DirectumTask8
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="BruteStringFileEnum" />.
    /// </summary>
    internal class BruteStringFileEnum : IEnumerator<string>
    {
        /// <summary>
        /// Defines the position.
        /// </summary>
        private int position = -1;

        /// <summary>
        /// Defines the collection.
        /// </summary>
        private List<string> collection;

        /// <summary>
        /// Initializes a new instance of the <see cref="BruteStringFileEnum"/> class.
        /// </summary>
        /// <param name="collection">The Str<see cref="List{string}"/>.</param>
        public BruteStringFileEnum(List<string> collection)
        {
            this.collection = collection;
        }

        /// <summary>
        /// Gets the Current.
        /// </summary>
        public string Current
        {
            get
            {
                return this.collection[this.position];
            }
        }

        /// <summary>
        /// Gets the Current.
        /// </summary>
        object IEnumerator.Current => this.Current;

        /// <summary>
        /// The MoveNext.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool MoveNext()
        {
            this.position++;
            if (this.position < this.collection.Count)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The Reset.
        /// </summary>
        public void Reset()
        {
            this.position = -1;
        }

        /// <summary>
        /// The Dispose.
        /// </summary>
        public void Dispose()
        {
        }
    }
}
