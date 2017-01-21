using System;
using TechTalk.SpecFlow;
using YourNamespace;

namespace SpecflowExercise1
{
    [Binding]
    public sealed class StepDefinition1: WebAutomation.SpecFlow.SpecFlowTestBase
    {
        private ContextItem context;
        public StepDefinition1(ScenarioContext sc, ContextItem context): base(sc)
        {
            this.context = context;
        }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            Console.WriteLine(context.ToString());
            context.value = number;
            context.message = "test";
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine(context.ToString());
        }


    }

    public class ContextItem
    {
        public int value { get; set; }
        public string message { get; set; }

        public override string ToString()
        {
            return $"value = {value}, message = {message}";
        }
    }
}
