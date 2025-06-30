using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Day9Csharp
{
    [Serializable]
    class Customer
    {
        public int CID;
        public string CustName;
    }
    class FileEg1
    {
        public static void Main()
        {
            Customer customer = new Customer() { CID = 101,CustName="Monali" };

            //IFormatter or Binary Formatter
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(@"C:\Banu\Infinite_June25\CSharp\Day9\FirstFile.txt",
                FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, customer);
            stream.Close();

            Console.WriteLine("-----Reading from file------");

            stream = new FileStream(@"C:\Banu\Infinite_June25\CSharp\Day9\FirstFile.txt",
                FileMode.Open, FileAccess.Read);

            Customer dcust = (Customer)formatter.Deserialize(stream);
            Console.WriteLine(dcust.CID + " " + dcust.CustName);
            Console.Read();

        }
    }
}
