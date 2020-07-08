namespace DirectumTask8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Найти максимальное значение в коллекции
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>                         // Stylecop. Он просит написать что-то осмысленное.
        /// <param name="val1">The val1<see cref="T"/>1 значение</param>
        /// <param name="val2">The val2<see cref="T"/>2 значение</param>
        /// <param name="val3">The val3<see cref="T"/>3 значение</param>
        /// <returns>The <see cref="T"/>Max value</returns>
        public static T FindMax<T>(T val1, T val2, T val3) 
        {
            List<T> values = new List<T> { val1, val2, val3 };
            return values.Max();
        }

        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            // Test FindMax value                      
            Console.WriteLine(FindMax(5, 55, 98));

            // generic list
            List<string> strings = new List<string> { "2 недели", "слишком мало", "для финального", "задания", "\n" };
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

            // generic dictionary
            Dictionary<string, int> diction = new Dictionary<string, int>();
            diction.Add("Кошка", 1);
            diction.Add("Собака", 2);
            diction.Add("Хомяк", 5);
            foreach (KeyValuePair<string, int> elem in diction)
            {
                Console.WriteLine($"key - {elem.Key}, value - {elem.Value}");
            }

            // test foreach in file
            BruteStringsFile vault = new BruteStringsFile("example.txt");   
            foreach (string s in vault)
            {
                Console.WriteLine(s);
            }
        }
    }
}
