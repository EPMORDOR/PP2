﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static bool isPrime(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); ++i)
                if (x % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText(@"C:\Users\admin\source\repos\Week 2\Task 2\input.txt").Split();
            using (StreamWriter file = new StreamWriter(@"C:\Users\admin\source\repos\Week 2\Task 2\output.txt"))
            {
                foreach (string number in text)
                {
                    int x = Convert.ToInt32(number);
                    if (isPrime(x))
                        file.Write(number + " ");
                }
            }
        }
    }
}
