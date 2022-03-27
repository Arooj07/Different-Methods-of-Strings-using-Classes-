using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRINGMethod
{
    internal class strMethodcheck
    {
        public void string_method1(string s)
          {
            Console.WriteLine("Output of String.Copy() Method");
            string New1;
            New1 = string.Copy(s);
            Console.WriteLine("New String After copying is: {0}", New1);
            Console.WriteLine("\n");
        }
        public void string_method2(string s1, string s2)
        {
            Console.WriteLine("Output of String.Compare() Method");
            int New2;
            New2 = string.Compare(s1,s2);
            if (New2 == 0)
                Console.WriteLine("Both Strings are same: {0}", New2.ToString());
            else if (New2 > 0)
                Console.WriteLine("First string is greater than second string: {0}", New2.ToString());
            else
                Console.WriteLine("Second String is greater than first string: {0}", New2.ToString());
        

        }
    }
}
