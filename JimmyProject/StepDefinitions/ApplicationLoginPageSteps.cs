using JimmyProject.PagesObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace JimmyProject.StepDefinitions
{
    [Binding]
    class ApplicationLoginPageSteps : BaseStep
    {
        LoginPageObjects loginPageObjects;

        [BeforeScenario]
        public void TeCleastnup()
        {
            
        }

        [Given(@"I am in Application Home Page")]
        public void GivenIAmInApplicationHomePage()
        {
            loginPageObjects = new LoginPageObjects(driver);
            setup();
        }

        [Given(@"I enter '(.*)' and '(.*)'")]
        public void GivenIEnterAnd(string p0, string p1)
        {
            loginPageObjects.ApplicationLogin(p0,p1);
        }

        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see Application Home Page")]
        public void ThenISeeApplicationHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I LogOff")]
        public void ThenILogOff()
        {
            ScenarioContext.Current.Pending();
        }

        [AfterScenario]
        public void TestCleanup()
        {
            driver.Close();

        }


    }
}
