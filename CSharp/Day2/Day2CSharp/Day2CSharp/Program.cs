using System;


namespace Day2CSharp
{
    class ArraysEg
    {
        public static void SingleDimension()
        {
            int[] arr = new int[] { 42, 6, 8, 35, 3 };
            Console.WriteLine(arr.Rank);

            foreach(int n in arr)
            {
                Console.WriteLine(n);
            }
        }

        public static void TwoDimension()
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(arr[1,1]);  // prints 5
            Console.WriteLine(arr.Length + " " + arr.Rank);
            //arr[0, 0] = 10;
            //arr[0, 1] = 20;
            //arr[1, 0] = 45;
            //we should use loops to accept and display array values

            //2 dimensional array will involve 2 loops
            //option 1:

            //for(int i=0; i<2;i++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        Console.Write(arr[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //option 2

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                   Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void JaggedArrays()
        {
            //1. declare jagged array of 2 rows
            int[][] myjagg = new int[2][];

            //2. now let us set the sixe for rach row
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];

            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 1;
            myjagg[1][1] = 3;

            //another way of initializing
            int[][] jagg2 =
            {
                new int[]{5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45},
                new int[]{50,55}
            };
            Console.WriteLine(jagg2.Length);
            //to display the jagged array elements
            for(int i=0; i < jagg2.Length;i++)
            {
                Console.WriteLine("Number of elements at Row : " + i + " is " + jagg2[i].Length);

                //inner loop
                for(int j=0; j < jagg2[i].Length;j++)
                {
                    Console.Write(jagg2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArraysEg.SingleDimension();
            Console.WriteLine("*************");
            ArraysEg.TwoDimension();
            Console.WriteLine("++++++++++++++++");
            ArraysEg.JaggedArrays();
            Console.Read();
        }
    }
}
