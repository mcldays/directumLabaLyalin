namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="Round" />.
    /// </summary>
    internal class Round : Circle
    {
        /// <summary>
        /// Gets the Circumference.
        /// </summary>
        public override double Circumference { get => 2 * Math.PI * this.Radius; }
    }
}
