using System;
using TechTalk.SpecFlow;

namespace SpecflowExercise1
{
    [Binding]
    public sealed class StepDefinition2 : WebAutomation.SpecFlow.SpecFlowTestBase
    {
        private ContextItem context;
        public StepDefinition2(ScenarioContext sc, ContextItem context) : base(sc)
        {
            this.context = context;
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            Console.WriteLine(context.ToString());
        }
    }
}
