using System;

namespace Day3CSharp
{
    public class AccessSepecifiersEg
    {
       private int privatemember;
        public int publicmember;
        protected int protectedmember;
        internal int internalmember;
        internal protected int internalprotectedmember;

        void Allaccessfunction()
        {
            privatemember = 1;
            publicmember = 2;
            protectedmember = 3;
            internalmember = 4;
            internalprotectedmember = 5;
        }
               
    }

    class TestAccessibilty : AccessSepecifiersEg
    {
        public void CheckAccess()
        {
            AccessSepecifiersEg aeg = new AccessSepecifiersEg();
            aeg.publicmember = 10;
            aeg.internalmember = 20;
            aeg.internalprotectedmember = 30;

            TestAccessibilty ta = new TestAccessibilty();
            ta.publicmember = 100;
            ta.internalmember = 200;
            ta.internalprotectedmember = 300;
            ta.protectedmember = 400;
        }
    }
}
