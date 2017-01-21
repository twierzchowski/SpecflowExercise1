using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecflowExercise1
{
    [Binding]
    public sealed class WebHooks: WebAutomation.SpecFlow.SpecFlowTestBase
    {
        public WebHooks(ScenarioContext sc): base(sc)
        {}

        [BeforeScenario("web")]
        public void BeforeScenario()
        {
            WebDriver = new ChromeDriver();
        }

        [AfterScenario("web")]
        public void AfterScenario()
        {
            WebDriver?.Quit();
        }
    }
}
