using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using MOQ_Project;


namespace CalculatorTests
{
    public class TestCalculator
    {
        [Test]
        public void Add_2_Nos_Returns_CorrectTotal()
        {
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(s => s.Add(3, 3)).Returns(6);
           
            //act
            var result = mockCalculator.Object.Add(3,3);

            //assert
            ClassicAssert.AreEqual(6, result);
        }

    }
}
