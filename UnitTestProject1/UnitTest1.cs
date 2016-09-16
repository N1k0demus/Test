using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testdemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculator()
        {
            Calculator calc = new Calculator
();
            
            //arrange
            int tal1 = 5;
            int tal2 = 3;
            int summa = 8;
            
            //act
            int result = calc.Sum(tal1, tal2);

            //assert
            Assert.AreEqual(summa, result, "Result is not equal to expected value" + result);
            
        }
    }
}
