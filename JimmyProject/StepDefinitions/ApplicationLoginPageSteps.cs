using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using JimmyProject.PagesObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace JimmyProject.StepDefinitions
{
    [Binding]
    class ApplicationLoginPageSteps : BaseStep
    {
        LoginPageObjects loginPageObjects ;
        //[BeforeTestRun]
        //public  ApplicationLoginPageSteps() : base (IWebDriver driver)
        //{
        //    loginPageObjects = new LoginPageObjects(driver);
        //}
        protected override void ClassInitialize()
        {
            loginPageObjects = new LoginPageObjects(driver);
        }

        [Given(@"I am in Application Home Page")]
        public void GivenIAmInApplicationHomePage()
        {
            loginPageObjects.ThenISeeApplicationHomePage();          
        }
        [Given(@"I enter '(.*)' and '(.*)'")]
        public void GivenIEnterAnd(string p0, string p1)
        {
            loginPageObjects.ApplicationLogin(p0,p1);
        }
        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            Console.WriteLine("");
        }

        [Then(@"I see Application Home Page")]
        public void ThenISeeApplicationHomePage()
        {
            Console.WriteLine("");
        }

        [Then(@"I LogOff")]
        public void ThenILogOff()
        {
            Console.WriteLine("");

        }  


    }
}
