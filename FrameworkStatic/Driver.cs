using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void Initialize()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }
        public static void OpenPage(string url)
        {
            driver.Url = url;
            //driver.Navigate().GoToUrl(url); // kitoks metodas atidaryti url
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}
