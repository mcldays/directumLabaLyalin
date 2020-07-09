namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="Circle" />.
    /// </summary>
    internal class Circle : RoundedFigures
    {
        /// <summary>
        /// Gets the Circumference.
        /// </summary>
        public override double Circumference { get => 2 * Math.PI * this.Radius; }

        /// <summary>
        /// Gets or sets the Area.
        /// </summary>
        public override double Area { get; set; }
    }
}
