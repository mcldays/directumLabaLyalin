﻿namespace DirectumTask3.Task3
{
    using System;

    /// <summary>
    /// Defines the <see cref="AccessRight" />.
    /// </summary>
    internal class AccessRight
    {
        /// <summary>
        /// Defines the AccessRights.
        /// </summary>
        [Flags, Serializable]
        public enum AccessRights : byte // Лучше вынести в отдельный файл.
        {
            /// <summary>
            /// Defines the View.
            /// </summary>
            View = 1,

            /// <summary>
            /// Defines the Run.
            /// </summary>
            Run = 2,

            /// <summary>
            /// Defines the Add.
            /// </summary>
            Add = 4,

            /// <summary>
            /// Defines the Edit.
            /// </summary>
            Edit = 8,

            /// <summary>
            /// Defines the Ratify.
            /// </summary>
            Ratify = 16,

            /// <summary>
            /// Defines the Delete.
            /// </summary>
            Delete = 32,

            /// <summary>
            /// Defines the AccessDenied.
            /// </summary>
            AccessDenied = 64
        }
    }
}
