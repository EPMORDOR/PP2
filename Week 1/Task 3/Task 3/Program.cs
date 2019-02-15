using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());// converting the char from the string to integer
            int[] a = new int[n];// adding massive a[n]
            string [] s = Console.ReadLine().Split();// spliting chars by space from the string to massive
            for(int i=0; i<n; i++)
            {
                a[i] = Convert.ToInt32(s[i]);// converting chars that is in s[i] to integer in a[i]
                for (int j=1; j<=2; j++)
                {
                    Console.Write(a[i] + " ");// showing them in one line 
                }
            }

        }
    }
}
