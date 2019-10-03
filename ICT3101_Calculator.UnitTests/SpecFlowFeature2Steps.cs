using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        private Calculator _calculator;
        private double _result;
        // Context Injection for SpecFlow:
        public void UsingCalculatorDivisionSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveAOneCalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            
             _result = _calculator.Divide(p0, p1);
            
        }

        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be Infinity")]
        public void ThenTheDivisionResultShouldPositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
        
          
    }
}
