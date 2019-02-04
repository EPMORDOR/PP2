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
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int[] ans = new int[n];
            string[] s = Console.ReadLine().Split();
            int cnt = 0;
            bool prime = true;
            for (int i = 0; i < n; ++i)
            {
                prime = true;
                a[i] = Convert.ToInt32(s[i]);
                if (a[i] == 1) prime = false;
                for (int j = 2; j < a[i]; ++j)
                {
                    if (a[i] % j == 0)
                        prime = false;
                   
                }
                if (prime == true)
                {
                    ans[cnt] = a[i];
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < cnt; ++i)
            {
                Console.Write(ans[i] + " ");
            }
        }
    }
}
