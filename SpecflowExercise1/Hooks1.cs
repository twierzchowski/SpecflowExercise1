using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoDi;
using TechTalk.SpecFlow;

namespace SpecflowExercise1
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly IObjectContainer objectContainer;
        public Hooks1(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            var x = new ContextItem {message = "hello", value = 42};
            objectContainer.RegisterInstanceAs<ContextItem>(x);
            
        }



        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
