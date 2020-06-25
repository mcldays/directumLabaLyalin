namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="Triangle" />.
    /// </summary>
    internal class Triangle : NotRoundedFigure
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
                var basis = Math.Sqrt(Math.Pow(dots[0].X - dots[1].X, 2) +
                           Math.Pow(dots[0].Y - dots[1].Y, 2));
                var area = (this.Height * basis) / 2;
                return area;
            }
        }
    }
}
