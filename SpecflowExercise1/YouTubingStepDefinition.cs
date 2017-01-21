using TechTalk.SpecFlow;
using YourNamespace;

namespace SpecflowExercise1
{
    [Binding]
    public sealed class YouTubingStepDefinition : WebAutomation.SpecFlow.SpecFlowTestBase
    {
        public YouTubingStepDefinition(ScenarioContext sc): base(sc)
        {}

        [When(@"I youtube for '(.*)'")]
        public void WhenIYoutubeFor(string text)
        {
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl("http://www.youtube.com");

            GetContainer<YoutubePage>().SearchInput.Perform.Fill(text);
            GetContainer<YoutubePage>().OkButton.Perform.Click();
        }

        [Then(@"I should see '(.*)'")]
        public void ThenIShouldSee(string title)
        {
            GetContainer<YoutubeSearchResultPage>().Link.With(title).Assert.WillBe.Present();
        }


    }
}
