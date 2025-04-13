using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestFramework.Driver
{
    public  class CustomWebDriverManager
    {
        private IWebDriver? driver;

        public IWebDriver InitializeDriver()
        {
            if (driver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
            }
            return driver;
        }

        public void QuiteDriver()
        {
            driver.Quit();
        }
    }
}
