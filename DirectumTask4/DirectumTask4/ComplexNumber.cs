namespace DirectumTask4
{
    using System;

    /// <summary>
    /// Defines the <see cref="Complex" />.
    /// </summary>
    internal class Complex : IComparable<Complex>
    {
        /// <summary>
        /// Defines the number.
        /// </summary>
        public Complex number;  // Зачем?

        /// <summary>
        /// Initializes a new instance of the <see cref="Complex"/> class.
        /// </summary>
        /// <param name="imaginary">The imaginary<see cref="double"/>.</param>
        /// <param name="notional">The notional<see cref="double"/>.</param>
        public Complex(double imaginary, double notional)
        {
            this.number = new Complex(imaginary, notional); // То есть тут конструктор вызывает сам себя? Будет stackoverflow exception.
        }

        /// <summary>
        /// Gets the Notional.
        /// </summary>
        public double Notional => this.number.Notional; // Тут нужен только { get; }

        /// <summary>
        /// Gets the Imaginary.
        /// </summary>
        public double Imaginary => this.number.Imaginary;

        /// <summary>
        /// Gets the Absolute.
        /// </summary>
        public double Absolute
        {
            get { return Math.Sqrt(Math.Pow(Notional, 2) + Math.Pow(Imaginary, 2)); }
        }

        /// <summary>
        /// The CompareTo.
        /// </summary>
        /// <param name="other">The other<see cref="Complex"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CompareTo(Complex other)
        {
            if (this.Absolute < other.Absolute) // Нужно проверить other на null.
            {                                   // А проверку можно сделать проще return this.Absolute.CompareTo(other.Absolute);
                return -1;
            }
            else if (this.Absolute > other.Absolute)
            {
                return 1;
            }

            return 0;
        }
    }
}
