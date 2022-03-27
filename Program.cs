using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRINGMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            strMethodcheck obj = new strMethodcheck();
            Console.WriteLine("Enter First String:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Entered First String is: " + str1);
            Console.WriteLine("\n");
            Console.WriteLine("Enter Second String:");
            string str2 = Console.ReadLine();
            Console.WriteLine("Entered Second String is: " + str2);
            Console.WriteLine("\n");
            obj.string_method1(str1);
            obj.string_method2(str1,str2);


        }
    }
}
