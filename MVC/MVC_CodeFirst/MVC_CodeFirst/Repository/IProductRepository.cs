using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Repository
{
    public interface IProductRepository<T> where T:class
    {
        IEnumerable<T> GetAll();  //get all products
        T GetByID(object Id); //to get a particular product
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
    }
}
