using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day12Csharp_1
{
    class ExpressionTrees
    {
        static void Main()
        {
            Func<string, string, string> stringJoin = (s1, s2) => String.Concat(s1, s2);

            Expression<Func<string, string, string>> stringJoinExpr = (s1, s2) => String.Concat(s1, s2);

            var result = stringJoinExpr.Compile()("Banu", "Rekha");
            Console.WriteLine(result);

            //create an expression tree that takes 2 int and returns the sum of the 2 

            Console.Read();
        }
    }
}
