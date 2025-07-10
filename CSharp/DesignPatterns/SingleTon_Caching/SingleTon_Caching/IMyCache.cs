using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace SingleTon_Caching
{
    public interface IMyCache
    {
        bool Add(object key, object value);
        bool AddOrUpdate(object key, object value);
        bool Remove(object key);
        object Get(object key);

        ConcurrentDictionary<object, object> GetAll();
    }
}
