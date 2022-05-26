using DigitalAutomationQuoteTest.AutomationFramework.PageObjects;
using DigitalAutomationQuoteTest.Extensions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DigitalAutomationQuoteTest.StepDefinitions
{
    [Binding]
    public sealed class HelloWorldSteps
    {
        private readonly ScenarioContext scenarioContext;

        public HelloWorldSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        private AutomationTechTestLandingPage AutomationTechTestLandingPage { get { return new AutomationTechTestLandingPage(this.scenarioContext.Driver()); } }

        [Given(@"the user is on the dotnetfiddle\.net landing page")]
        public void GivenTheUserIsOnTheDotnetfiddle_NetLandingPage()
        {
            
        }

        [When(@"I click run button")]
        public void WhenIClickRunButton()
        {
            this.AutomationTechTestLandingPage.RunButton.Click();
        }


        [Then(@"I should see '(.*)' in output window")]
        public void ThenIShouldSeeInOutputWindow(string txtdisplay)
        {
            Assert.AreEqual(txtdisplay, this.AutomationTechTestLandingPage.TextMessage);
        }





    }
}
