namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="NotRoundedFigures" />.
    /// </summary>
    internal class NotRoundedFigures : Shape  // Лучше назвать в единственном числе и сделать абстрактным.
    {
        /// <summary>
        /// Gets or sets the Area.
        /// </summary>
        public virtual double Area { get; set; }  // Площадь может быть и у RoundedFigures. Можно сделать абстрактным и перенести в Shape.

        /// <summary>
        /// Gets the Perimeter
        /// Gets or sets the Perimeter..
        /// </summary>
        public virtual double Perimeter
        {
            get
            {
                double perimeter = 0;
                for (int i = 0; i < XCoordinates.Count; i++)
                {
                    perimeter += Math.Sqrt(Math.Pow(this.XCoordinates[i] - this.XCoordinates[i + 1], 2) +
                                           Math.Pow(this.YCoordinates[i] - this.YCoordinates[i + 1], 2));
                }

                return perimeter;
            }
        }
    }
}
