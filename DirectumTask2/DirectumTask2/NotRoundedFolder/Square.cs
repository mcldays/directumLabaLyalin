namespace DirectumTask2.NotRoundedFolder
{
    using System;

    /// <summary>
    /// Defines the <see cref="Square" />.
    /// </summary>
    internal class Square : NotRoundedFigures
    {
        /// <summary>
        /// Gets the Area.
        /// </summary>
        public override double Area
        {
            get
            {
                var basis = Math.Sqrt(Math.Pow(XCoordinates[0] - XCoordinates[1], 2) +
                                      Math.Pow(YCoordinates[0] - YCoordinates[1], 2));
                return Math.Pow(basis, 2);
            }
        }
    }
}
