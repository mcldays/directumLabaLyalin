namespace DirectumTask2
{
    /// <summary>
    /// Defines the <see cref="RoundedFigures" />.
    /// </summary>
    internal abstract class
        RoundedFigures : Shape // Зачем вдруг тут и в некоторых других местах перенос на следующую строку?
    {
        /// <summary>
        /// Gets or sets the Radius.
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// Gets the Circumference
        /// Gets or sets the Circumference...
        /// </summary>
        public abstract double Circumference { get; }
    }
}
