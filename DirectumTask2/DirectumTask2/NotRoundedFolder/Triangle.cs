namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="Triangle" />.
    /// </summary>
    internal class Triangle : NotRoundedFigures
    {
        /// <summary>
        /// Gets or sets the Height.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets the Area.
        /// </summary>
        public override double Area
        {
            get
            {
                var basis = Math.Sqrt(Math.Pow(XCoordinates[0] - XCoordinates[1], 2) +
                           Math.Pow(YCoordinates[0] - YCoordinates[1], 2));
                var area = (this.Height * basis) / 2;
                return area;
            }
        }
    }
}
