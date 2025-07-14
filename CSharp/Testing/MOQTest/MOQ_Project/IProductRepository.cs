using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ_Project
{
    public interface IProductRepository
    {
        Products GetByID(int id);
    }
}
