using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\admin\source\repos\Week 2\Task 4\Task 4\input.txt";
            string path1 = @"C:\Users\admin\source\repos\Week 2\Task 4";
            DirectoryInfo dirInfo = new DirectoryInfo(path1);
            FileInfo fi = new FileInfo(path);
            if (fi.Exists && dirInfo.Exists)
            {
                fi.CopyTo(path1 + @"\Copied.txt", true);
                fi.Delete();
            }
            else Console.WriteLine("path or path1 not found:(");
        }
    }
}
