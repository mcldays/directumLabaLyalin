namespace Task5
{
    using System;
    using System.IO;
    using System.Reflection;

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
            PrintProp(Path.Combine(Directory.GetCurrentDirectory(), "Task1Old.dll"), "Task1.UserModel");
            PrintProp(Path.Combine(Directory.GetCurrentDirectory(), "Task1New.dll"), "Task1.UserModel");
            Console.ReadLine();
        }

        /// <summary>
        /// The PrintProp.
        /// </summary>
        /// <param name="path">The path<see cref="string"/>.</param>
        /// <param name="className">The className<see cref="string"/>.</param>
        public static void PrintProp(string path, string className)
        {
            var asm = Assembly.LoadFile(path);
            var t = asm.GetType(className, true, true);
            var properties = t.GetProperties();
            var obj = Activator.CreateInstance(t);
            foreach (var property in properties)
            {
                if (property.CanRead)
                {
                    Console.WriteLine(property.GetValue(obj));
                }
            }
        }
    }
}
