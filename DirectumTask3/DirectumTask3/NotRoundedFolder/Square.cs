namespace DirectumTask2.NotRoundedFolder
{
    using System;

    /// <summary>
    /// Defines the <see cref="Square" />.
    /// </summary>
    internal class Square : NotRoundedFigure
    {
        /// <summary>
        /// Gets the Area.
        /// </summary>
        public override double Area
        {
            get
            {
                var basis = Math.Sqrt(Math.Pow(dots[0].X - dots[1].X, 2) +
                                      Math.Pow(dots[0].Y - dots[1].Y, 2));
                return Math.Pow(basis, 2);
            }
        }
    }
}
