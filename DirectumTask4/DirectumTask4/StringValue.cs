namespace DirectumTask4
{
    using System;

    /// <summary>
    /// Defines the <see cref="StringValue" />.
    /// </summary>
    internal class StringValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringValue"/> class.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        public StringValue(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the Value.
        /// </summary>
        public string Value { get; private set; }


        public static bool operator ==(StringValue val1, StringValue val2) => val1.Value == val2.Value;
        public static bool operator !=(StringValue val1, StringValue val2) => val1.Value != val2.Value;
        /// <summary>
        /// The Equals.
        /// </summary>
        /// <param name="obj">The obj<see cref="object"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public override bool Equals(object obj)
        {
            return obj is StringValue value && this.Value == value.Value;
        }

        /// <summary>
        /// The GetHashCode.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Value);
        }
    }
}
