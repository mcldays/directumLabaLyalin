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
            Permission(AccessRight.AccessRights.View | AccessRight.AccessRights.Add |
                                   AccessRight.AccessRights.Edit
                                   | AccessRight.AccessRights.AccessDenied);
            Console.ReadKey();
        }

        /// <summary>
        /// The Permission.
        /// </summary>
        /// <param name="data">The data<see cref="AccessRight.AccessRights"/>.</param>
        internal static void Permission(AccessRight.AccessRights data)
        {
            if ((data & AccessRight.AccessRights.AccessDenied) == AccessRight.AccessRights.AccessDenied)
            {
                Console.WriteLine("Доступ запрещен");
            }
            else
            {
                Console.WriteLine("Permission:{0}", data);
            }
        }
    }
}
