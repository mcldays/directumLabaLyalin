namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="Ring" />.
    /// </summary>
    internal class Ring : RoundedFigures  // Возможно кольцо тоже может от чего-то наследоваться.
    {
        // Не хватает свойства внутреннего радиуса кольца.

        /// <summary>
        /// Gets the Circumference.
        /// </summary>
        public override double Circumference { get => 2 * Math.PI * this.Radius; }
    }
}
