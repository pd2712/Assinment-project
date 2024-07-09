using orangehrmlive.com.Base;
using orangehrmlive.com.Pages;
using orangehrmlive.com.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orangehrmlive.com.Test
{
    public class LoginTest : AutomationWrapper
    {

        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginData))]
        
        public void ValidLoginTest(string username, string password, string expectedTitle)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

            
            MainPage mainPage = new MainPage(driver);
            string actualTitle = mainPage.GetMainPageTitle();

            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData))]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

           
            string actualError = loginPage.Invalidcredentials();
            Assert.That(actualError, Is.EqualTo(expectedError));
        }

    }
}
