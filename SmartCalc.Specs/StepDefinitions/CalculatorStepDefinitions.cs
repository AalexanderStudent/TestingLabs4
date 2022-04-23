using SmartCalculator;
using FluentAssertions;

namespace SmartCalc.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly Calculator _calculator = new Calculator();
        private readonly ScenarioContext _scenarioContext;
        private int _result;
        private Exception _divByZeroException = null;


        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are subtract")]
        public void WhenTheTwoNumbersAreSubtract()
        {
            _result = _calculator.Sub();
        }

        [When("the two numbers are multiply")]
        public void WhenTheTwoNumbersAreMultiply()
        {
            _result = _calculator.Mult();
        }


        [When("the two numbers are divide")]
        public void WhenTheTwoNumbersAreDivide()
        {
            _divByZeroException = null;
            try
            {
                _result = _calculator.Div();
            }
            catch (Exception ex)
            {
                _divByZeroException = ex;
            }

        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Then("should be thrown DiviedByZeroException")]
        public void ShouldBeThrownDiviedByZeroException()
        {
            _divByZeroException.Should().NotBeNull();

            if (_divByZeroException != null)
                _divByZeroException.GetType().FullName.Should().Be(new DivideByZeroException().GetType().FullName);

        }
    }
}