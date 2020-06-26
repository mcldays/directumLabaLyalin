namespace DirectumTask5
{
    using System;

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
            Console.WriteLine("Hello World!");
            IntervalTime kek = new IntervalTime();
            kek.RecordsCount("ClientConnectionLog.log", new DateTime(2007, 12, 7), new DateTime(2007, 12, 17));
        }
    }
}
