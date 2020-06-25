namespace DirectumTask2
{
    /// <summary>
    /// Defines the <see cref="RoundedFigures" />.
    /// </summary>
    internal abstract class
        RoundedFigures : Shape // Лучше сделать абстрактным. И будет правильнее назвать в единственном числе(RoundedFigure).
    {
        /// <summary>
        /// Gets or sets the Radius.
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// Gets the Circumference
        /// Gets or sets the Circumference..
        /// </summary>
        public abstract double
Circumference
        { get; }
    }
}
