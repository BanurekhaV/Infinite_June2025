using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries
{
    class Linq_Ops
    {
        static void Main(string[] args)
        {
            Aggregates_General();
            Seed_Aggregates();
            Console.WriteLine("--------------------");
            Element_At();
            Console.WriteLine("--------------------");
            First_Operators();
            Console.WriteLine("--------------------");
            Single_Ops_Eg();
            Console.WriteLine("----------------------");
            Sorting_func();
            Console.WriteLine("-------------------------");
            InnerJoins();
            Console.WriteLine("---------------------------");
            Group_By_Func();
            Console.WriteLine("**************************");
            Group_Join();
            Console.Read();
        }

        public static void Aggregates_General()
        {
            int[] numbers = { 2, 34, 5, 6, 7, 8, 9 };
            var sum = numbers.Sum();
            var max = numbers.Max();
            var avg = numbers.Average();
            Console.WriteLine($"Sum : {sum}, Average :{avg}, Max : {max}");
        }

        //aggregation

        static void Seed_Aggregates()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate(10, (a, b) => a + b);  //25

            Console.WriteLine("Aggregate Sum with Seed :{0}", result);

            result = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Just Aggregate :{0}", result);  //120

        }

        static void Element_At()
        {
            string[] fruits = { "Apples", "Oranges", "Kiwi", "Bananas", "Grapes" };
            var result = fruits.ElementAt(3); //bananas
            Console.WriteLine(result);
            //result = fruits.ElementAt(5); //throws an exception

            //to avoid exceptions
             result = fruits.ElementAtOrDefault(5); //does not throw Exception instead returns null
            Console.WriteLine(result);
        }

        static void First_Operators()
        {
            string[] colors = { "Red", "Blue", "Green", "Yellow", "White" };

            Console.WriteLine(colors.First());
            Console.WriteLine(colors.Last());

            //empty collection
            string[] colors1 = { };
            Console.WriteLine(colors1.FirstOrDefault());
            Console.WriteLine(colors1.LastOrDefault());
        }

        static void Single_Ops_Eg()
        {
            string[] names1 = { "Narendra Modi" };
            string [] names2 = { "Donald Trump", "Nitanhu", "Barack Obama" };
            string[] empty = { };

            Console.WriteLine(names1.Single());
           // Console.WriteLine(names2.Single()); // throws exception
           // Console.WriteLine(names2.SingleOrDefault()); // throws exception
           // Console.WriteLine(empty.Single()); //throws an exception
          //  Console.WriteLine(empty.SingleOrDefault()); // does not throw exception
        }

        static void Sorting_func()
        {
            string[] names2 = { "Donald Trump", "Nitanhu", "Barack Obama" };

            //sort asc
            var namesort = names2.OrderBy(n => n);
            foreach(var nm in namesort)
            {
                Console.WriteLine(nm);
            }
            Console.WriteLine("-------Descending Sort --------");

            namesort = names2.OrderByDescending(n => n);
            foreach (var nm in namesort)
            {
                Console.WriteLine(nm);
            }

            //multiple sorts

            string[] capitals = { "Nagpur","Delhi", "Mumbai","Ambal","abcde", "Hyderabad", "Bangalore", "Chennai", "Vishakapatnam"};
            var mulsort = capitals.OrderBy(c => c.Length).ThenBy(c => c);
            Console.WriteLine("------- Ascending Multi Sort--------");
            foreach(string s in mulsort)
            {
                Console.WriteLine(s);
            }

            mulsort = capitals.OrderByDescending(c => c.Length).ThenByDescending(c => c);
            Console.WriteLine("------- Descending Multi Sort--------");
            foreach (string s in mulsort)
            {
                Console.WriteLine(s);
            }
        }

        static void InnerJoins()
        {
            string[] str1 = { "India", "Japan", "US", "Korea", "Russia" };
            string[] str2 = { "China", "Pakistan", "Japan", "India", "Korea", "UK" };

            var result = str1.Join(str2, s1 => s1, s2 => s2, (s1, s2) => s2);
            Console.WriteLine("-----Post Join------");
            foreach(var country in result)
            {
                Console.WriteLine(country);
            }
        }

        static void Group_By_Func()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35, 42 };
            var result = numbers.GroupBy(num => (num % 10 == 0));  //query construction

            foreach(IGrouping<bool,int> gp in result)  // query execution
            {
                if(gp.Key ==  true)
                {
                    Console.WriteLine("Group 1 : - Numbers Divisible by 10..");
                }
                else
                {
                    Console.WriteLine("Group 2 : - Numbers Not divisible by 10..");
                }
                foreach(int n in gp)
                {
                    Console.WriteLine(n);
                }
            }
        }

        static void Group_Join()  //wprks like a left outer join
        {
            
            Language[] languages = new Language[]
            {
                new Language{Id = 1, Name="English"},
                new Language{Id = 2, Name = "German"},
                 new Language{Id = 3, Name = "Spanish"},
            };

            
            Person[] persons = new Person[]
            {
                new Person{LanguageId = 1, PersonName ="Naveen"},
                new Person{LanguageId = 1, PersonName ="Sathish"},
                new Person{LanguageId = 2, PersonName ="Naresh"},
                new Person{LanguageId = 2, PersonName ="Sudesh"},
                new Person{LanguageId = 1, PersonName ="Nithya"},
            };

            var result = languages.GroupJoin(persons, l => l.Id, p => p.LanguageId,
                (lang, ps) => new { Key = lang.Name, Person = ps });

            foreach(var language in result)
            {
                Console.WriteLine(String.Format("Persons speaking {0} :", language.Key));
                foreach(var person in language.Person)
                {
                    Console.WriteLine(person.PersonName);
                }
            }
        }
    }

    class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Person
    {
        public int LanguageId { get; set; }
        public string PersonName { get; set; }
    }
}

