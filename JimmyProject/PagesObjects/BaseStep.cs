using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace JimmyProject.PagesObjects
{
    public class BaseStep
    {

        public  IWebDriver driver = new ChromeDriver();

        public void setup()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URl"]);
        }
     

    }
} 
