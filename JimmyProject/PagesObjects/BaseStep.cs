using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using JimmyProject.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace JimmyProject.PagesObjects
{

    //static class InitialSetUpClass
    //{
    //    public static ApplicationExtentReports applicationExtentReports = new ApplicationExtentReports();

    //}
    public class BaseStep
    {
        public static ExtentReports extentReports;
        public static ExtentV3HtmlReporter htmlreport;
        public static ExtentTest extentTest;
        public static IWebDriver driver;
        [BeforeScenario]
        public static void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URl"]);
            Console.WriteLine("BeforeScenario- Navigate");
        }
        [BeforeTestRun]
        public static void TestInitup()
        {
            htmlreport = new ExtentV3HtmlReporter(@"C:\Users\Jimmy\Documents\Visual Studio 2015\Projects\AcceptanceTest\JimmyProject\TestResults\ExtentsReports.html");
            extentReports.AttachReporter(htmlreport);
        }


        [AfterScenario]
        public static void TestCleanup()
        {
            driver.Close();
            driver.Quit();
            Console.WriteLine("AfterScenario- Quit");
        }
        [BeforeFeature]
        public static void ReportAfterStep()
        {
            extentReports.CreateTest(FeatureContext.Current.FeatureInfo.Title);
            
        }
        [BeforeStep]
        public static void ReportBeforeFeatureStep()
        {
            extentReports.CreateTest(ScenarioStepContext.Current.StepInfo.Text);
        }
        [AfterTestRun]
        public static void TearDown()
        {
            extentReports.Flush();
            
        }
    }
} 
