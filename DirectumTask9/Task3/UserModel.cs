namespace Task3
{
    using System;

    /// <summary>
    /// Defines the <see cref="UserModel" />.
    /// </summary>
    internal class UserModel
    {
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Age.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the Surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the PetsNumber.
        /// </summary>
        [Obsolete]
        public int PetsNumber { get; set; }
    }
}
