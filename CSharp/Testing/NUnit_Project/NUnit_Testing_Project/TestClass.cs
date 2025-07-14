using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnit_Project;


namespace NUnit_Testing_Project
{
    [TestFixture]
    public class TestClass
    {
        Employee emp;
       [SetUp]
        public void ArrangeObjects()
        {
            emp = new Employee();
        }
        [Test]
       // [Ignore("Wait for sometime")]
        public void TestEmployeeDetails_for_non_nullValues()
        {
             List<Employee> elist = emp.EmployeeList();

            foreach(var item in elist)
            {
                ClassicAssert.IsNotNull(item.ID);
                ClassicAssert.IsNotNull(item.Name);
            }
        }

        [Test]
        [TestCase(15,35,50)]
        [TestCase(10,45,55)]
        [TestCase(20,50,70)]
        public void TestingAdd2Nos_with_Testcases(int n1, int n2, int expected)
        {
            int res = emp.Add2nos(n1, n2);
            ClassicAssert.AreEqual(expected, res);
        }

        [Test]
        public void Testing_LoginMethod()
        {
            //act
            string s1= emp.Login("Banurekha", "AAA");
            string s2 = emp.Login("", "");
            string s3 = emp.Login("Admin", "Admin@123");

            //assert
            ClassicAssert.AreEqual("User id or Password cannot be empty", s2);
            ClassicAssert.AreEqual("Incorrect Userdid or Password", s1);
            ClassicAssert.AreEqual("Welcome Admin", s3);
        }

        //testing reservation cancellation
        [Test]
        public void CancellationByAdmin_ReturnsTrue()
        {
            //Arrange 
            var reservation = new Reservation();

            //Act
            var result = reservation.CanbeCancelledBy(new User { IsAdmin = true });

            //Assert
            ClassicAssert.IsTrue(result);
        }
        [Test]
        public void CancellationByBookedBy_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { bookedBy = user};
            var result = reservation.CanbeCancelledBy(user);
            ClassicAssert.IsTrue(result);   
        }
        [Test]
        public void Cancellation_MadeBy_Others_ReturnsFalse()
        {
            var reservation = new Reservation(){ bookedBy = new User()};
            var result = reservation.CanbeCancelledBy(new User());
            ClassicAssert.IsFalse(result);
        }
    }
}
