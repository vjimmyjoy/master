using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System.IO;

namespace JimmyProject.Infrastructure
{
    public class ApplicationExtentReports
    {
        public ExtentReports extent;
        public ExtentV3HtmlReporter htmlreport;
        public ExtentTest test;
        string filepath= @"C:\Users\Jimmy\Documents\Visual Studio 2015\Projects\AcceptanceTest\JimmyProject\TestResults\re.html";
        //string localpath;
        
        public void AddTestLog(Status logStatus, string log) => test.Log(logStatus,log);
        public void CloseReport() => extent.Flush();

        public void DeclareExtentRepo()
        {
             htmlreport = new ExtentV3HtmlReporter(@"C:\Users\Jimmy\Documents\Visual Studio 2015\Projects\AcceptanceTest\JimmyProject\TestResults\ExtentsReports.html");
             extent.AttachReporter(htmlreport);
        }

        public void CreateExtentRepro(string featureName)
        {
            test = extent.CreateTest<Feature>(featureName);
        }
    }
}
