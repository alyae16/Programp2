using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Function();
        }
        private static void Function()
        {
            DirectoryInfo lol = new DirectoryInfo(@"C:\Users\user\Documents\ez");
            print(lol, 1);

        
}
        private static void print(FileSystemInfo f, int k) 
        {
            string line = new string(' ', k); 
            line = line + f.Name;  
            Console.WriteLine(line);

            if (f.GetType() == typeof(DirectoryInfo))
            {
                var str = (f as DirectoryInfo).GetFileSystemInfos(); 
                foreach (var i in str) 
                {
                    print(i, k + 4);
                }
            }
        }

        
    }
}

