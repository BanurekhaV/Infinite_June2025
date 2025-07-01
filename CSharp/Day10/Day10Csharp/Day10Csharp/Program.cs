using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Day10Csharp
{
    class Program
    {
        static void WriteBinary()
        {
            using(BinaryWriter writer = new BinaryWriter(File.Open("C:\\Banu\\Infinite_June25\\CSharp\\MyBinfile.bin",FileMode.Create)))
            {
                writer.Write("0x823440x5");
                writer.Write("This is creating a file");
                writer.Write(true);
            }
        }

        static void ReadBinary()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("C:\\Banu\\Infinite_June25\\CSharp\\MyBinfile.bin", FileMode.Open)))
            {
                Console.WriteLine("String : " + reader.ReadString());
                Console.WriteLine("String 2: "+ reader.ReadString());
                Console.WriteLine("Bool Data : " + reader.ReadBoolean());
            }
        }
           
        //stream readers and writers class
        public static void WriteStream()
        {
            FileStream fs = new FileStream("OurStreamFile.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            //prompt the user for input
            Console.WriteLine("Enter a string :");
            string str = Console.ReadLine();
            //write the data to the undrlying stream
            sw.Write(str);
            //clear the buffer
            sw.Flush();
            //close the writer
            sw.Close();

            fs.Close();
        }

        public static void ReadStream()
        {
            FileStream fs = new FileStream("OurStreamFile.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);
            //positioning the file pointer at a place of choice in the file

            sr.BaseStream.Seek(5, SeekOrigin.Begin);

            //read till the end of file is encountered
            string str = sr.ReadLine();
            while(str !=null)
            {
                Console.WriteLine("{0}", str);
                str = sr.ReadLine();
            }
            //close the reader and the stream
            sr.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            //WriteBinary();
            //ReadBinary();
           // WriteStream();
            ReadStream();
            Console.Read();
        }
    }
}
