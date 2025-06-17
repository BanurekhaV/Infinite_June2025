using System;


namespace Day1Csharp
{
    class ControlStatements
    {
        #region
        static void Main()
        {
            ControlStatements cs = new ControlStatements();
            //char retgrade = cs.CheckGrade();
            //Console.WriteLine(retgrade);

            //or
            //  Console.WriteLine(cs.CheckGrade());
            IterationStatements loops = new IterationStatements();
            //  loops.WhileLoop();
            //  Console.WriteLine("************");
            // loops.DoWhileLoop();
            // Console.WriteLine("************");
            // loops.ForLoop();
            loops.ForEachLoop();
            Console.Read();
        }
        #endregion
        #region
        public char CheckGrade()
        {
            char grade;
           // int maths = 96; ;
            Console.WriteLine("Enter your Grade :");
            grade = Convert.ToChar(Console.ReadLine());
            if(grade =='O' || grade =='o')
                Console.WriteLine("Outstanding");
            else if(grade =='A' || grade =='a')
                Console.WriteLine("Excellent");
            else if (grade == 'B' || grade == 'b')
                Console.WriteLine("Very Good");
            else if (grade == 'C' || grade == 'c')
                Console.WriteLine("Fair");            
            else            
                Console.WriteLine("Invalid Grade");
            return grade;
        }
        #endregion

        /// <summary>
        /// the below function works on multiple switch clauses
        /// </summary>
        public void CheckGrade_with_Switch()
        {
            ////multiple switch cases
            //int intval =0;
            //string strval ="Hi";
            //bool boolval = true;
            //switch((intval, strval, boolval))
            //{
            //    case (0, "Hi", true):
            //        Console.WriteLine("All Met..");
            //        break;
            //    case (1, "Hello", true):
            //}
        }
    }

    class IterationStatements
    {
        public void WhileLoop()
        {
            int i = 1;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForLoop()
        {
            int tot = 0;
            int i = 0;
            for (; i<=5; i++)
            {
                if (i == 3)
                     break;
                    //continue;
                Console.WriteLine(i);
                tot += i;
            }
            Console.WriteLine("Sum of all numbers {0}", tot);
        }

        public void ForEachLoop()
        {
            int[] data = new int[] { 76, 4, 12, 0, 3 };
            Console.WriteLine(data.Length);
            Console.WriteLine("------Before Sort --------");
            foreach(int x in data)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("------After Sort --------");
            Array.Sort(data);
            foreach (var x in data)
            {
                Console.WriteLine(x);
            }
        }
    }
}
