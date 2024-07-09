using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orangehrmlive.com.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(By.Name("password")).SendKeys(password);
        }
        public void ClickOnLogin()
        {
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }
    }
}
