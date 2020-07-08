using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProp(Path.Combine(Directory.GetCurrentDirectory(), "Task1Old.dll"), "Task1.UserModel");
            PrintProp(Path.Combine(Directory.GetCurrentDirectory(), "Task1New.dll"), "Task1.UserModel");
            Console.ReadLine();
        }


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
