namespace DirectumTask2
{
    using System;

    /// <summary>
    /// Defines the <see cref="Ring" />.
    /// </summary>
    internal class Ring : Circle
    {
        /// <summary>
        /// Gets or sets the InnerRadius
        /// Gets the Circumference..
        /// </summary>
        public double InnerRadius { get; set; }

        /// <summary>
        /// Gets the Circumference.
        /// </summary>
        public override double Circumference { get => 2 * Math.PI * this.Radius; }
    }
}
