using System;
using Day3CSharp;


namespace AccessTest_Prj
{
    class AccesTest_Program : AccessSepecifiersEg
    {
        static void Main(string[] args)
        {
            AccessSepecifiersEg ag = new AccessSepecifiersEg();
            ag.publicmember = 1000;

            AccesTest_Program atp = new AccesTest_Program();
            atp.publicmember = 0;
            atp.protectedmember = 2000;
            atp.internalprotectedmember = 3000;
        }
    }
}
