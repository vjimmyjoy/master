using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace JimmyProject.PagesObjects
{
    public class LoginPageObjects : BasePage
    {
        
        IWebElement UserName => driver.FindElement(By.Id("txtUserName"));
        IWebElement Password => driver.FindElement(By.Id("txtPassword"));
        public LoginPageObjects(IWebDriver edriver)
        {
            driver = edriver;
        }        
        public void ApplicationLogin(string uname,string pawd)
        {
            UserName.SendKeys(uname);
            Password.SendKeys(pawd);
        }
        public void ThenISeeApplicationHomePage()
        { string actuals = driver.FindElement(By.ClassName("h2Contentleft")).Text.Trim();
           Assert.AreEqual("Log on to CommBiz", actuals);
            Console.WriteLine("Added from origin master");
        }
        
    }
}
