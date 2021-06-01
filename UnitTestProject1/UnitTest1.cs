using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Calculator_Summ_12and13_index0_result25()
        {
            //arrange
            double num1 = 12;
            double num2 = 13;
            int index = 0;
            double resultSum = 25;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Summ_m12andm13_index0_resultm25()
        {
            //arrange
            double num1 = -12;
            double num2 = -13;
            int index = 0;
            double resultSum = -25;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Summ_2dot5and1dot5_index0_result4()
        {
            //arrange
            double num1 = 2.5;
            double num2 = 1.5;
            int index = 0;
            double resultSum = 4;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Subtract_5and2_index1_result3()
        {
            //arrange
            double num1 = 5 ;
            double num2 = 2;
            int index = 1;
            double resultSum =3 ;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Subtract_m5andm2_index1_resultm3()
        {
            //arrange
            double num1 = -5;
            double num2 = -2;
            int index = 1;
            double resultSum = -3;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Subtract_3dot5and1dot2_index1_result2dot3()
        {
            //arrange
            double num1 = 3.5;
            double num2 = 1.2;
            int index = 1;
            double resultSum = 2.3;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Multiplication_2and3_index2_result6()
        {
            //arrange
            double num1 = 2;
            double num2 = 3;
            int index = 2;
            double resultSum = 6;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Multiplication_m2and3_index2_resultm6()
        {
            //arrange
            double num1 = -2;
            double num2 = 3;
            int index = 2;
            double resultSum = -6;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Multiplication_m2andm3_index2_result6()
        {
            //arrange
            double num1 = -2;
            double num2 = -3;
            int index = 2;
            double resultSum = 6;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }

        [TestMethod]
        public void TestMethod_Calculator_Division_10and2_index3_result5()
        {
            //arrange
            double num1 = 10;
            double num2 = 2;
            int index = 3;
            double resultSum = 5;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }

        [TestMethod]
        public void TestMethod_Calculator_Division_10andm2_index3_resultm5()
        {
            //arrange
            double num1 = 10;
            double num2 = -2;
            int index = 3;
            double resultSum = -5;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }
        [TestMethod]
        public void TestMethod_Calculator_Division_m10andm2_index3_result5()
        {
            //arrange
            double num1 = -10;
            double num2 = -2;
            int index = 3;
            double resultSum = 5;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }

        [TestMethod]
        public void TestMethod_Calculator_Exponentiation_3and2_index4_result9()
        {
            //arrange
            double num1 = 3;
            double num2 = 2;
            int index = 4;
            double resultSum = 9;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }

        [TestMethod]
        public void TestMethod_Calculator_Exponentiation_100andm1_index0dot01_result9()
        {
            //arrange
            double num1 = 100;
            double num2 = -1;
            int index = 4;
            double resultSum = 0.01;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }

        [TestMethod]
        public void TestMethod_Calculator_Exponentiation_m2and2_index4_result9()
        {
            //arrange
            double num1 = -2;
            double num2 = 2;
            int index = 4;
            double resultSum = 4;
            //act
            var ex = Calculations.Calculator(num1, num2, index);
            //assert
            Assert.AreEqual(ex, resultSum);
        }




    }
}
