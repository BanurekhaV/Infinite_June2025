using System;


namespace Day5Csharp
{
    class Phone
    {
        public string Brand { get; set; }

        public void PhoneFeatures()
        {
            Console.WriteLine("Features of the Phone" + " " + Brand);
        }
    }

    class OnePlus: Phone
    {
        public new string Brand { get; set; } //name hiding (property)
        public new void PhoneFeatures()   // name hiding (method)
        {
            Console.WriteLine("One Plus Mobile Features.." + " " + Brand);
            ShowPhoneType();
        }

        public void ShowPhoneType()
        {
            Console.WriteLine("Brand in base type Phone : {0}", base.Brand);
            Console.WriteLine("Brand in derived type Phone : {0}", Brand);
        }
    }
    class NameHiding
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Brand = "Mobile Phone";
           // phone.PhoneFeatures();
          
            //OnePlus op = new OnePlus();
          

            //op.Brand = "One Plus 21";
            ////  op.PhoneFeatures();
            //op.ShowPhoneType();
            phone = new OnePlus();
            phone.Brand = "One Plus";
            phone.PhoneFeatures();
            //phone.PhoneFeatures();
            Console.Read();
        }
    }
}
