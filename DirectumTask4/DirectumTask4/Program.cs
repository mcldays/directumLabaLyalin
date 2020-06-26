namespace DirectumTask4
{
    using System;
    using System.Collections;

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
            Console.WriteLine(new StringValue("AAA").Equals(new StringValue("AAA")));
            Console.WriteLine(new StringValue("AAA") == new StringValue("AAA"));

            var TwoComplexes = new ArrayList()  // 11 ошибок StyleCop в этом проекте.
            {
                new Complex(3, 5),
                new Complex(2, 2)
            };
            TwoComplexes.Sort();
        }
    }
}
