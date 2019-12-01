using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace JimmyProject.PagesObjects
{
    public class LoginPageObjects
    {
        IWebDriver driver;
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


    }
}
