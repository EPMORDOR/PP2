using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C:\Users\admin\source\repos\Week 2\Task 1\input.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine(s);

           
            int k = s.Length;
            for (int i=0; i<k/2; i++)
            {
                if (s[i] != s[k - 1 - i])
                {  Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
            
    }
    }
}
