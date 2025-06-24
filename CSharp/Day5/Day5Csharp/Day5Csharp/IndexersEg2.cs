using System;


namespace Day5Csharp
{
    class Users
    {
        //declaring an array field
        private string[] arr = new string[3];

        //define indexer for arr
        public string this[int i]
        {
            get { return arr[i];}
            set { arr[i] = value; }
        }

        //2. overloaded indexer for arr

        public string this[string s]
        {
            get
            {
                foreach(string str in arr)
                {
                    if(str.ToLower() == s.ToLower())
                    {
                        return str.ToUpper();
                    }
                }
                return null;
            }

        }
    }
    class IndexersEg2
    {
        static void Main()
        {
            Users user = new Users();

            //setting values using int indexer
            user[0] = "Nikitha";
            user[1] = "Nishitha";
            user[2] = "Naveen T";

            //accessing values using int indexer
            for(int i=0; i<3;i++)
            {
                Console.WriteLine(user[i]);
            }

            Console.WriteLine("------Accessing values using string indexer---------");

            Console.WriteLine(user["Nishitha"]);
            Console.WriteLine(user["Naveen"]);
            Console.WriteLine(user["Nikitha"]);
            Console.WriteLine("Third Example Execution");

            Indexer3 id3 = new Indexer3();
            id3[0] = "How";
            id3[1] = "are";
            id3[2] = "you";
            Console.WriteLine(id3[0] + id3[1] + id3[2]);

            id3[0.1f] = "Csharp";
            id3[1.1f] = "Java";
            id3[2.1f] = "Python";

            Console.WriteLine(id3[0.1f] + id3[1.1f] + id3[2.1f]);
            Console.Read();
        }
    }

    class Indexer3
    {
        private string[] word = new string[3];

        public string this[int x]
        {
            get { return word[x]; }
            set { word[x] = value; }
        }

        public string this[float f]
        {
            get { return word[(int)f]; }
            set { word[(int)f] = value; }
        }
    }
}
