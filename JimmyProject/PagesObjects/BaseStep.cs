using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace JimmyProject.PagesObjects
{
    //[Binding]
    public class BaseStep
    {
        public static ExtentReports extentReports;
        public  ExtentV3HtmlReporter htmlreport;
        public  ExtentTest extentTest;
        public  IWebDriver driver;
        [BeforeScenario]
        public  void OneTimesetup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URl"]);
            Console.WriteLine("BeforeScenario- Navigate");
            ClassInitialize();
            Report();
        }

        protected virtual void ClassInitialize()
        {
            //This method is overriden in implentation class
        }
        //[BeforeTestRun]
        public void Report()
        {
            Console.WriteLine("BeforeTest- REports");
            //htmlreport = new ExtentV3HtmlReporter(@"C:\Users\Jimmy\Documents\Visual Studio 2015\Projects\AcceptanceTest\JimmyProject\TestResults\ExtentsReports.html");
            //extentReports.AttachReporter(htmlreport);

            extentReports = new ExtentReports();
            //var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\");
            //DirectoryInfo di = Directory.CreateDirectory(dir + “\\Test_Execution_Reports”);
            var htmlReporter = new ExtentV3HtmlReporter(@"C:\Users\Jimmy\Documents\Visual Studio 2015\Projects\AcceptanceTest\JimmyProject\TestResults\ExtentsReports.html");
            extentReports.AddSystemInfo("Environment", "Journey of Quality");
            extentReports.AddSystemInfo("User Name", "Sanoj");
            extentReports.AttachReporter(htmlReporter);
            extentReports.CreateTest(FeatureContext.Current.FeatureInfo.Title);          
        }
        [AfterScenario]
        public void TestCleanup()
        {
            extentReports.Flush();
            driver.Close();
            driver.Quit();
            Console.WriteLine("AfterScenario");
        }
        //[BeforeFeature]
        //public static void ReportAfterStep()
        //{
        //    Console.WriteLine("BeforeFeature");
        //    Report();
        //    extentReports.CreateTest(FeatureContext.Current.FeatureInfo.Title);

        //}
        //[BeforeStep]
        //public static void ReportBeforeFeatureStep()
        //{
        //    Console.WriteLine("BeforeStep");
        //    extentReports.CreateTest(ScenarioStepContext.Current.StepInfo.Text);
        //}
        [BeforeFeature]
        public static void TearDown() => Console.WriteLine("BeforeFeature");
        [BeforeScenarioBlock]
        public static void BeforeScenarioBlock() => Console.WriteLine("BeforeScenarioBlock");
        [BeforeStep]
        public static void BeforeStep() => Console.WriteLine("BeforeStep");
        [BeforeTestRun]
        public static void BeforeTestRun() => Console.WriteLine("BeforeTestRun");

    }
} 
