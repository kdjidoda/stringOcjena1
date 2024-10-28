using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more. ";
            string s2 = "Italija je prvak svijeta";
            

            Console.WriteLine(s1.Replace ("ima more.", s2));

            Console.ReadKey();
        
        }
    }
}
