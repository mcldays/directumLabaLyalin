namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

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
            var dictionary = GetPropFromAnyProj("Task1.dll", "Task1.UserModel");    // Лучше добавить библиотеку в проект как файл.
            Console.WriteLine("\n");
            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine($"{keyValuePair.Key} | {keyValuePair.Value}");
            }
        }

        /// <summary>
        /// The GetProp.
        /// </summary>
        /// <param name="assembly">The assembly<see cref="string"/>Solution.</param>
        /// <param name="className">The className<see cref="string"/>Class name.</param>
        /// <returns>The <see cref="Dictionary{string, string}"/>.</returns>
        public static Dictionary<string, string> GetPropFromAnyProj(string assembly, string className)
        {
            var dictionary = new Dictionary<string, string>();
            var asm = Assembly.LoadFrom(assembly);
            var type = asm.GetType(className);
            if (type == null)
            {
                return dictionary;
            }

            Console.WriteLine($"Solution Name: {asm.FullName}");
            Console.WriteLine($"Type Name: {type.Name} | Namespace: {type.Namespace}");
            var instance = Activator.CreateInstance(type, null);
            var props = instance?.GetType().GetProperties();
            if (props != null)
            {
                foreach (var item in props)
                {
                    if (item.CanRead && item.CanWrite)
                    {
                        dictionary.Add(item.Name, item.GetValue(instance)?.ToString());
                    }
                }
            }

            return dictionary;
        }
    }
}
