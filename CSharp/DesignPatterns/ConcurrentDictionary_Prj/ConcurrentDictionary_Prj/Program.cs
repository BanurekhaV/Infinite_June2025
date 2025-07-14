using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

namespace ConcurrentDictionary_Prj
{
    class Program
    {
        static Dictionary<string, int> _mydic = new Dictionary<string, int>();

        static ConcurrentDictionary<string, int> _mycondic = new ConcurrentDictionary<string, int>();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(InsertData));
            Thread t2 = new Thread(new ThreadStart(InsertData));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            t1 = new Thread(new ThreadStart(InsertDataConcurrent));
            t2 = new Thread(new ThreadStart(InsertDataConcurrent));

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine($"Results in the Dictionay Object : {_mydic.Values.Count}");
            Console.WriteLine("*************************************************");
            Console.WriteLine($"Results in the Concurrent Dictionay Object : {_mycondic.Values.Count}");
                      
            Console.Read();
        }

        
        static void InsertData()
        {
            for(int i=0; i<100;i++)
            {
                _mydic.Add(Guid.NewGuid().ToString(), i);
            }
        }

        static void InsertDataConcurrent()
        {
            for (int i = 0; i < 100; i++)
            {
                _mycondic.TryAdd(Guid.NewGuid().ToString(), i);
            }
        }
    }
}
