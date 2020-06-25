namespace DirectumTask2
{
    /// <summary>
    /// Defines the <see cref="Shape" />.
    /// </summary>
    public abstract class Shape  // Лучше сделать класс абстрактным.
    {
        /// <summary>
        /// Gets or sets the Area.
        /// </summary>
        public abstract double Area { get; set; }

        /// <summary>
        /// Gets the dots.
        /// </summary>
        public System.Drawing.Point[] dots { get; }
    }
}
