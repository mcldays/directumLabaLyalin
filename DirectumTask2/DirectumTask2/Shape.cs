namespace DirectumTask2
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Shape" />.
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// Gets or sets the XCoordinates.
        /// </summary>
        public List<int> XCoordinates { get; set; }

        /// <summary>
        /// Gets or sets the YCoordinates.
        /// </summary>
        public List<int> YCoordinates { get; set; }

        /// <summary>
        /// Gets or sets the Radius.
        /// </summary>
        public int Radius { get; set; }
    }
}
