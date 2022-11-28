using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Var_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            string name = "Andres";

            Console.WriteLine("integer variable = " + i);
            Console.WriteLine("string variable = " + name);

            var vs = name;
            Console.WriteLine("var can be a string = " + vs);

            var vi = i;
            Console.WriteLine("var can be an integer = " + vi);

            var vf = 5.5f;
            Console.WriteLine("var can be a float = " + vf);
        }
    }
}
