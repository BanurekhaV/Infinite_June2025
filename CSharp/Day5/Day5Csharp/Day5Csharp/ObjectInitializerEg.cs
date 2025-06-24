using System;

namespace Day5Csharp
{
    class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime MfgDate { get; private set; } = Convert.ToDateTime("02/05/1998");

        public void ShowProducts()
        {
            Console.WriteLine($"{ID}, {Name},{Price}.{MfgDate}");
        }
    }
    class ObjectInitializerEg
    {
        static void Main()
        {
            Products products = new Products { ID = 1, Name = "Gucci Bags", Price = 5000 };
            products.ShowProducts();
           
            //anonymous data types
            var atype = new
            {
                data1 = "CSharp",
                data2 = 10,
                data3 = true,
                data4 = new Products() { ID=100, Name="Infinite", Price=500}
            };
            Console.WriteLine(atype.GetType().ToString());
            Console.WriteLine("Details of the Object " + atype.data4.ID + " " + atype.data4.Name);
            Console.Read();
        }
    }
}
