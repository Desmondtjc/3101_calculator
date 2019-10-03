using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class SpecFlowFeature4Steps
    {
        private Calculator _calculator;
        private double _result;

        [Given(@"I have a availability calculator")]
        public void GivenIHaveAOneCalculator()
        {
            _calculator = new Calculator();
        }


        [When(@"I have entered  ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void GivenIHaveEnteredIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void GivenIHaveEnteredIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the result MTBF result should be ""(.*)""")]
        public void ThenTheResultMTBFResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the result availability result should be ""(.*)""")]
        public void ThenTheResultAvailabilityResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
