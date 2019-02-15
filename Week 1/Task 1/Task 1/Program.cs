using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // taking integer from string by using convert
            int[] a = new int[n]; // adding new massive that will be full by numbers that we will write in string
            int[] ans = new int[n]; // adding new massive to add prime numbers in that massive
            string[] s = Console.ReadLine().Split(); // spliting string through the space " "
            int cnt = 0; // adding integer that will count number of prime
            bool prime = true; // using boolean 
            for (int i = 0; i < n; ++i)
            {
                prime = true;
                a[i] = Convert.ToInt32(s[i]);//converting to int from char
                if (a[i] == 1) prime = false; // 
                for (int j = 2; j < a[i]; ++j)
                {
                    if (a[i] % j == 0)// if remainder will be zero it means that number is not prime 
                        prime = false;
                   
                }
                if (prime == true)
                {
                    ans[cnt] = a[i];//cnt=0 than it is growing so we are fill in massive ans by prime numbers
                    cnt++;
                }
            }
            Console.WriteLine(cnt);// we show the number of prime numbers
            for (int i = 0; i < cnt; ++i)// this cycle used to show prime numbers
            {
                Console.Write(ans[i] + " ");// we are showing in console the prime numbers
            }
            Console.WriteLine();
        }
    }
}
