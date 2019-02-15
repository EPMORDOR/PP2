using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());// converting char from the string to integer
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; ++j)
                    Console.Write("[*]");//showing the char [*] 
                Console.Write("\n");//we are skipping one line and then writing next string

            }
        }
    }
}
