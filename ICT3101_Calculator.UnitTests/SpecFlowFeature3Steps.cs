using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class SpecFlowFeature3Steps
    {
        private Calculator _calculator;
        private double _result;

        [Given(@"I press factorial")]
        public void GivenIHaveAOneCalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered ""(.*)"" into the calculator")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFactorial(int p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
