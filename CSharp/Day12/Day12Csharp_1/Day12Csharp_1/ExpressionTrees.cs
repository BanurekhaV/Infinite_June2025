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

            //creating expression trees using API
            //1. create parameter
            ParameterExpression n1 = Expression.Parameter(typeof(int), "n1");
            ParameterExpression n2 = Expression.Parameter(typeof(int), "n2");

            //2. Create expression parameters
            ParameterExpression[] parameters = new ParameterExpression[] { n1, n2 };

            //3. Create expression body
            BinaryExpression exprbody = Expression.Add(n1, n2);

            //4. Create the expression
            Expression<Func<int, int, int>> expr = Expression.Lambda<Func<int, int, int>>(exprbody, parameters);

            //5. Compile the expression
            Func<int, int, int> compiledexpr = expr.Compile();

            //6. Execute the expression
            int res = compiledexpr(10, 20);
            Console.WriteLine("Expression using API resulted in {0}", res);

            Console.Read();
        }
    }
}
