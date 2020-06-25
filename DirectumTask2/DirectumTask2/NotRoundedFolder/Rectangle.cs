namespace DirectumTask2.NotRoundedFolder
{
    using System;

    /// <summary>
    /// Defines the <see cref="Rectangle" />.
    /// </summary>
    internal class Rectangle : NotRoundedFigure
    {
        /// <summary>
        /// Gets the Area.
        /// </summary>
        public override double Area
        {
            get
            {
                var a = Math.Sqrt(Math.Pow(this.dots[0].X - this.dots[1].X, 2) +
                                      Math.Pow(this.dots[0].Y - this.dots[1].Y, 2));
                var b = Math.Sqrt(Math.Pow(this.dots[2].X - this.dots[3].X, 2) +
                                              Math.Pow(this.dots[2].Y - this.dots[3].Y, 2));

                return a * b;
            }
        }
    }
}
