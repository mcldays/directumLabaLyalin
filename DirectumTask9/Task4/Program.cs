using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new ReadingAppConfig();
            Console.WriteLine(reader.GetCommonParameterFromConfig("IntProp"));
            Console.WriteLine(reader.GetCommonParameterFromConfig("StrProp"));
            Console.WriteLine(reader.GetCommonParameterFromConfig("BoolProp"));
            Console.ReadKey();
        }
    }
}
