using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSIClientX.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculator_Addition_Success_Test()
        {
            var expected = 4;
            var calc = new DSIClientX.csharp.Calculator();
            var result = calc.Add(2, 2);
            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void Calculator_Addition_Failure_Test()
        {
            var expected = 2;
            var calc = new DSIClientX.csharp.Calculator();
            var result = calc.Add(2, 2);
            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void Calculator_Multiplication_Success_Test()
        {
            var expected = 4;
            var calc = new DSIClientX.csharp.Calculator();
            var result = calc.Multiplication(2, 2);
            Assert.IsTrue(result == expected);
        }

    }
}
