using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_Caching
{
    class Program
    {
        static void Main(string[] args)
        {
            //obtaining a singleton instance
            SingleTonCache cache = SingleTonCache.GetInstance();

            //1. add some data to the cache
            Console.WriteLine("Adding Keys and Values to the cache----");
            Console.WriteLine($"Adding EID as Key to the cache : {cache.Add("EID",101)}");
            Console.WriteLine($"Adding EName as another key to the cache : {cache.Add("EName","Sowmya")}");

            Console.WriteLine($"Adding EID as Key to the cache : {cache.Add("EID", 102)}");
            Console.WriteLine($"Adding EName as another key to the cache : {cache.Add("EName", "Sravya")}");

            Console.WriteLine($"Adding EID as Key to the cache : {cache.Add("EID", 103)}");
            Console.WriteLine($"Adding EName as another key to the cache : {cache.Add("EName", "Sai Satya")}");

            //2. Retrive data from the cache
            Console.WriteLine("Fetching Data from the collection");
            Console.WriteLine($"Getting Employee ID from cache : {cache.Get("EID")}");
            Console.WriteLine($"Getting Employee Name from cache : {cache.Get("EName")}");

            //3.calling add or update
           // Console.WriteLine($"Adding the existing key to check AddorUpdate() : {cache.AddOrUpdate("EID",102)}");

            //4. removing a key
           // Console.WriteLine("Removing Key from cache");

           // Console.WriteLine($"Removing ID 101 : {cache.Remove("EID")}");
            //   Console.WriteLine($"Getting Employee ID from cache : {cache.Get("EID")}");


            //Console.WriteLine("Fetching Data from the collection");
            //Console.WriteLine($"Getting Employee ID from cache : {cache.Get("EID")}");
            //Console.WriteLine($"Getting Employee Name from cache : {cache.Get("EName")}");
            Console.Read();
        }
    }
}
