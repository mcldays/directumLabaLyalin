namespace DirectumTask3
{
    using System;
    using DirectumTask3.Task3;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            AccessRight.Permission(AccessRight.AccessRights.View | AccessRight.AccessRights.Add |
                                   AccessRight.AccessRights.Edit
                                   | AccessRight.AccessRights.AccessDenied);
            Console.ReadKey();
        }
    }
}
