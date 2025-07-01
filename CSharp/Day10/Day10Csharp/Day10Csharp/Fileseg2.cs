using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Day10Csharp
{
    //fileinfo and directory info classes
    class Fileseg2
    {
        static void Main()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Banu\Infinite_June25\TestDir");

            if(dinfo.Exists)
            {
                Console.WriteLine("Directory by the name already exists..");
            }
            else
            {
                dinfo.Create();
                Console.WriteLine("new Directory Created..");
            }
            Console.WriteLine("---Iterating the subdirectories of the given directory---");
            DirectoryInfo di = new DirectoryInfo(@"C:\Banu\Infinite_June25\CSharp");
            if(di.Exists)
            {
                DirectoryInfo[] subdirs = di.GetDirectories();

                foreach(object obj in subdirs)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
            else
            {
                Console.WriteLine("The given directory does not exists..");
            }

            //getting files of the directory
            Console.WriteLine("-----files from a directory----");

            FileInfo[] finfo = di.GetFiles();

            foreach(FileInfo f in finfo)
            {
                Console.WriteLine("File Name : {0} Size : {1} ",f.Name, f.Length);
            }
            Console.Read();
        }
    }
}
