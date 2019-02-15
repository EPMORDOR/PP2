using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_3
{
    class Program
    {
        static void rec(DirectoryInfo dir, string level)
        {
            Console.WriteLine(level + dir.Name);
            level += "    ";
            FileSystemInfo[] fs = dir.GetFileSystemInfos();
            for (int i = 0; i < fs.Length; ++i)
            {
                if (fs[i].GetType() == typeof(FileInfo))
                {
                    Console.WriteLine(level + fs[i].Name);
                }
                else
                {
                    rec(fs[i] as DirectoryInfo, level);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\admin\source\repos\Week 2\Task 3\Жизнь");
            rec(dir, "");
        }
    }
}
