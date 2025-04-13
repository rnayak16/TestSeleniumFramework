using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.BiDi.Modules.Browser;
using TestFramework.Driver;
using TestFramework.PageObjectModel;
using TestFramework.LogAndreport;
using NUnit.Framework;
using log4net.Repository.Hierarchy;
using OpenQA.Selenium.Chrome;
using Logger = TestFramework.LogAndreport.Logger;

namespace TestFramework.Tests.Login
{
    [TestFixture]
    
    public class LoginSuccessFul
    {
        
        private WebDriverManager webDriverManager;
        private LoginPage loginPage;
        //Logger logger = new Logger();

        [SetUp]
        public void Setup()
        {

            //webDriverManager = new WebDriverManager();
            //var driver = webDriverManager.InitializeDriver();
            //loginPage = new LoginPage(driver);
            //webDriverManager = new WebDriverManager();

            Logger.LogInfo("Inside setup Method");
            webDriverManager = new WebDriverManager();
            var driver = webDriverManager.InitializeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void LoginTest()
        {
            try
            {
                loginPage.EnterCredentials("admin", "password123");
                loginPage.ClickLogin();

                //Assert.IsTrue(true); // Replace with actual validation logic

            }
            catch(Exception ex)
            {
                //Logger.LogError(ex.Message);
                //Lo
                //throw;
            }


        }

        [TearDown]
        public void Teardown()
        {
            //webDriverManager.QuitDriver();
            webDriverManager.QuiteDriver();
        }
    }
}
