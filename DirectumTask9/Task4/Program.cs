namespace Task4
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
            var reader = new ReadingAppConfig();
            Console.WriteLine(reader.GetCommonParameterFromConfig("IntProp"));
            Console.WriteLine(reader.GetCommonParameterFromConfig("StrProp"));
            Console.WriteLine(reader.GetCommonParameterFromConfig("BoolProp"));
            Console.ReadKey();
        }
    }
}
