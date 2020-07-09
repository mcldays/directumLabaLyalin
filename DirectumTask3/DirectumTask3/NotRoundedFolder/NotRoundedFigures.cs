namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="NotRoundedFigure" />.
    /// </summary>
    internal abstract class NotRoundedFigure : Shape  // Лучше назвать в единственном числе и сделать абстрактным.
    {
        /// <summary>
        /// Gets the Perimeter
        /// Gets or sets the Perimeter....
        /// </summary>
        public virtual double Perimeter
        {
            get
            {
                double perimeter = 0;

                for (int i = 0; i < dots.Length; i++)
                {
                    perimeter += Math.Sqrt(Math.Pow(this.dots[i].X - this.dots[i + 1].X, 2) +
                                           Math.Pow(this.dots[i].Y - this.dots[i + 1].Y, 2));
                }

                return perimeter;
            }
        }

        /// <summary>
        /// Gets or sets the Area.
        /// </summary>
        public override double Area { get; set; }
    }
}
