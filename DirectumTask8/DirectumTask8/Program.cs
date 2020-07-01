using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectumTask8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMax(5,55,98));

            // generic list
            List<string> strings = new List<string> { "2 недели", "слишком мало", "для финального", "задания", "\n" };
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            
            //generic dictionary
            Dictionary<string, int> diction = new Dictionary<string, int>();
            diction.Add("Кошка", 1);
            diction.Add("Собака", 2);
            diction.Add("Хомяк", 5);
            foreach (KeyValuePair<string, int> elem in diction)
            {
                Console.WriteLine($"key - {elem.Key}, value - {elem.Value}");
            }

            BruteStringsFile vault = new BruteStringsFile(@".\example.txt");
            foreach (string s in vault)
            {
                Console.WriteLine(s);
            }

            


        }

        public static T FindMax<T>(T val1, T val2, T val3)
        {
            List<T> values = new List<T> { val1, val2, val3 };
            return values.Max();
        }
    }




}
