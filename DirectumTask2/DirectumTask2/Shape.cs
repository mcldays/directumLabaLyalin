namespace DirectumTask2
{
    /// <summary>
    /// Defines the <see cref="Shape" />.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Gets or sets the Area.
        /// </summary>
        public abstract double Area { get; set; }

        /// <summary>
        /// Gets the dots.
        /// </summary>
        public System.Drawing.Point[] dots { get; } //  StyleCop. + Пространство имён лучше вынести вверх в using.
    }
}
