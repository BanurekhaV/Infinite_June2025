using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_Caching
{
    public sealed class SingleTonCache : IMyCache
    {
        // Since shared resources have to be protected in a multithreaded environment
        // , we can use ConcurrentDictionary collection which enables thread safety

        private ConcurrentDictionary<object, object> cd = new ConcurrentDictionary<object, object>();

        //object for storing singleton instance
        private static readonly SingleTonCache singleobj = new SingleTonCache();

        //private constructor

        private SingleTonCache()
        {
            Console.WriteLine("SingleTon Instance Created ...");
        }

        //providing static methods for instantiation and return the singleton object

        public static SingleTonCache GetInstance()
        {
            return singleobj;
        }


        //the below method will add a key and a value to the cache
        public bool Add(object key, object value)
        {
            return cd.TryAdd(key, value);
        }

        //the below method will check for the key, if found updates the value, else add
        public bool AddOrUpdate(object key, object value)
        {
            if(cd.ContainsKey(key))
            {
                 cd.TryRemove(key, out object removedvalue);
                //cd.TryUpdate(key, "Sree", "Sowmya");
            }
            return cd.TryAdd(key, value);
        }

        //the below method will return a value of a specified key if found, else null
        public object Get(object key)
        {
            if(cd.ContainsKey(key))
            {
                return cd[key];
            }
            return null;
        }

        //the below method will remove a key and its value from the cache
        public bool Remove(object key)
        {
            return cd.TryRemove(key, out object removedval);
        }

        //one instance method
        public void Clear()
        {
            cd.Clear();
        }

        public ConcurrentDictionary<object,object>GetAll()
        {
            return cd;
        }
    }
}
