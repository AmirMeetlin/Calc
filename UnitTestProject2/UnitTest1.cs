using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calc;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Calculator_Summ_12and13_result25()

        {

            //arrange

            string expression ="12+13";

            double result = 25;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }
        
        [TestMethod]

        public void TestMethod_Calculator_Summ_m12andm13_resultm25()

        {

            //arrange

            string expression = "-12-13";

            double result = -25;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Summ_2dot5and1dot5_result4()

        {

            //arrange

            string expression = "2,5+1,5";

            double result = 4;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Subtract_5and2_result3()

        {

            //arrange

            string expression = "5-2";

            double result = 3;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Subtract_m5andm2_index1_resultm3()

        {

            //arrange

            string expression = "-5-2";

            double result = -3;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Subtract_3dot5and1dot2_result2dot3()

        {

            //arrange

            string expression = "3,5-1,2";

            double result = 2.3;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Multiplication_2and3_result6()

        {

            //arrange

            string expression = "2x3";

            double result= 6;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Multiplication_m2and3_resultm6()

        {

            //arrange

            string expression = "-2x3";

            double result = -6;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Multiplication_1dot5and2_result3()

        {

            //arrange

            string expression = "1,5x2";

            double result = 3;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Division_10and2_result5()

        {

            //arrange

            string expression = "10:2";

            double result = 5;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Division_10andm2_index3_resultm5()

        {

            //arrange

            string expression = "10:-2";

            double result = -5;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Division_6andm1dot5_result4()

        {

            //arrange

            string expression = "6:1,5";

            double result= 4;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }
        [TestMethod]

        public void TestMethod_Calculator_Exponentiation_3and2_result9()

        {

            //arrange

            string expression = "3^2";

            double result = 9;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Exponentiation_0dot2and2_result0dot04()

        {

            //arrange

            string expression = "0,2^2";

            double result = 0.04;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }

        [TestMethod]

        public void TestMethod_Calculator_Exponentiation_m2and2_result9()

        {

            //arrange

            string expression = "-2^2";

            double result = 4;

            //act

            var ex = Calculations.Calculator(expression);

            //assert

            Assert.AreEqual(ex, result);

        }
    }
}
