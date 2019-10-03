using NUnit.Framework;
using ICT3101_Calculator;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenMinusTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Multiply(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }
        [Test]
        public void Divide_WhenDivideTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Divide(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

       // [Test]
       // [TestCase(0,0)]
       // [TestCase(0, 10)]
       // [TestCase(10, 0)]
        //public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a,int b)
        //{
         //   Assert.That(() => _calculator.Divide (a,b), Throws.ArgumentException);
        //}

        [Test]
        public void Factorial_WhenFactorialumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Factorial(3);
            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void MultiplyDiv_WhenDivMulTwoNumbersToGetTriangle_ResultEqualToSum()
        {
            // Act , To get Area of Triangle
            double result = (_calculator.Multiply(20, 10)) / 2;
            // Assert
            Assert.That(result, Is.EqualTo(100));
        }


        [Test]
        public void MultiplyDiv_WhenDivMulTwoNumbersToGetCircle_ResultEqualToSum()
        {
            // Act , To get Area of Cirlce
            double result = (_calculator.Multiply(10, 10) * 3.142) ;
            // Assert
            Assert.That(result, Is.EqualTo(314.2));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
    }
}

