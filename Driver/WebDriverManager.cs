using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFramework.Driver
{
    public  class WebDriverManager
    {
        private IWebDriver? driver;

        public IWebDriver InitializeDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver("C:\\Users\\admin\\Desktop\\Radhika\\ChromeDriver\\ChromeDriver");
            }
            return driver;
        }

        public void QuiteDriver()
        {
            driver.Quit();
        }
    }
}
