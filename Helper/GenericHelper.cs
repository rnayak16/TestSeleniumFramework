using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace TestFramework.Heler
{
    public class GenericHelper
    {
        public static object ExpectedConditions { get; private set; }

        public static void WaitForElement(IWebDriver driver, By locator, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            //wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
