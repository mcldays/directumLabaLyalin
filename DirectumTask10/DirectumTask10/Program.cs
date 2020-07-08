namespace DirectumTask10
{
    using System.IO;

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
            EarlyBind.Draw(Directory.GetCurrentDirectory() + @"\EarlyTable.xlsx");
            LazyBind.Draw(Directory.GetCurrentDirectory() + @"\LazyTable.xlsx");
        }
    }
}
