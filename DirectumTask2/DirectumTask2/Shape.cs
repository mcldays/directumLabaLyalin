namespace DirectumTask2
{
    using System.Drawing;

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
        public Point[] dots { get; }
    }
}
