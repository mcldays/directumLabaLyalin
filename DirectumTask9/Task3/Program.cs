namespace Task3
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        public static void Main()
        {
            var dictionary = GetProperties(new UserModel() { Name = "Олег", Age = 25, Surname = "Нечипоренко" });
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// The GetProperties.
        /// </summary>
        /// <param name="a">The a<see cref="object"/>.</param>
        /// <returns>The <see cref="Dictionary{string, string}"/>.</returns>
        public static Dictionary<string, string> GetProperties(object a)
        {
            var dictionary = new Dictionary<string, string>();
            var type = a.GetType();
            foreach (var item in type.GetProperties())
            {
                if (item.CanRead && item.CanWrite)
                {
                    dictionary.Add(item.Name, item.GetValue(a)?.ToString());
                }
            }

            return dictionary;
        }
    }
}
