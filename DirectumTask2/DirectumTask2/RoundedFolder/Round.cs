namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="Round" />.
    /// </summary>
    internal class Round : RoundedFigures // Круг может наследоваться от окружности.
    {
        /// <summary>
        /// Gets the Circumference.
        /// </summary>
        public override double Circumference { get => 2 * Math.PI * this.Radius; }
    }
}
