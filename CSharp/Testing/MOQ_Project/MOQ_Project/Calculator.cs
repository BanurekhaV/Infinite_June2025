using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ_Project
{
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Mutiply(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
