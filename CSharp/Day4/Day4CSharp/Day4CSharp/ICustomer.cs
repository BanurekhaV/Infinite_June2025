using System;


namespace Day4CSharp
{
    interface ICustomer 
    {
        //method declarations
        void Print();        
    }

    interface ISupplier
    {
        void Print();
    }
    class Customer : ICustomer, ISupplier
    {
        public void Print()   // default implementation
        {
            Console.WriteLine("Hello from Print Method of ICustomer");
        }   
        
        void ISupplier.Print() // explicit implementation
        {
            Console.WriteLine("Hello from Print Method of ISupplier");
        }
    }

    class InterfaceTester
    {
        static void Main()
        {
            
            Customer customer = new Customer();
             customer.Print(); //default method call

             //explicit implementation calls can be made as follows
             //1. 
            Console.WriteLine("***************");
            ((ICustomer)customer).Print(); 
            ((ISupplier)customer).Print();

            Console.WriteLine("******************");
            //or 
            //2. 
            ICustomer icust = new Customer();
            icust.Print();

            ISupplier isupp = new Customer();
            isupp.Print();
            Console.Read();
        }
    }
}
