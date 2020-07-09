namespace Task1
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
        public static void Main()   // Проект почему-то был библиотекой, а не консольным приложением.
        {
            var dict = GetReadingWritingProp(new UserModel { Name = "Лил", SecondName = "Чича" });
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// The GetProp.
        /// </summary>
        /// <param name="a">The a<see cref="object"/>.</param>
        /// <returns>The <see cref="Dictionary{string, string}"/>.</returns>
        public static Dictionary<string, string> GetReadingWritingProp(object a)
        {
            var dict = new Dictionary<string, string>();    // dictionary не такое длинное слово.
            var type = a.GetType();
            foreach (var item in type.GetProperties())
            {
                if (item.CanRead && item.CanWrite)
                {
                    dict.Add(item.Name, item.GetValue(a)?.ToString());
                }
            }

            return dict;
        }
    }
}
