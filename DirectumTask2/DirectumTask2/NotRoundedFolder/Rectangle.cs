namespace DirectumTask2.NotRoundedFolder
{
    using System;

    /// <summary>
    /// Defines the <see cref="Rectangle" />.
    /// </summary>
    internal class Rectangle : NotRoundedFigures
    {
        /// <summary>
        /// Gets the Area.
        /// </summary>
        public override double Area
        {
            get
            {
                var a = Math.Sqrt(Math.Pow(this.XCoordinates[0] - this.XCoordinates[1], 2) +
                                      Math.Pow(this.YCoordinates[0] - this.YCoordinates[1], 2));
                var b = Math.Sqrt(Math.Pow(this.XCoordinates[2] - this.XCoordinates[3], 2) +
                                              Math.Pow(this.YCoordinates[2] - this.YCoordinates[3], 2));

                return a * b;
            }
        }
    }
}
