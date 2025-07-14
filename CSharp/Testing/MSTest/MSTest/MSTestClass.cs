using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace MSTest
{
    [TestClass]
    public class MSTestClass
    {
        [TestMethod]
        public void Method1()
        {
            Trace.WriteLine("TestMethod 1");
        }
        [TestMethod]
        public void Method2()
        {
            Trace.WriteLine("TestMethod 2");
        }

        [TestInitialize]
        public void BeforeAllTests()
        {
            Trace.WriteLine("Called Before Every Test");
        }

        [TestCleanup]
        public void AfterAllTests()
        {
            Debug.Print("Called After Every Test");
        }

        [ClassInitialize]
        public static void OnceFor_theClass(TestContext tc)
        {
            Trace.WriteLine("Called Once for the Entire Class");
        }

        [ClassCleanup]
        public static void OnceFor_Disposal_oftheClass()
        {
            Trace.WriteLine("Called after the Class is unloaded");
        }
        [AssemblyInitialize]
        public static void At_theStart_ofthe_Assembly(TestContext tc)
        {
            Trace.WriteLine("Once for the Entire Assembly");
        }

        [AssemblyCleanup]

        public static void At_theEnd_ofthe_Assembly()
        {
            Trace.WriteLine(" Entire Assembly Clean up");
        }
    }

}
