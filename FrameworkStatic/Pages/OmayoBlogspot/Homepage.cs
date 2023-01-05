using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.OmayoBlogspot
{
    public class Homepage
    {
        public static void Open()
        {
            string url = "https://omayo.blogspot.com/";
            Driver.OpenPage(url);
        }

        public static void ClearTextBoxWithpreloadedText()
        {
            string locator = "//*[@id=\"textbox1\"]";
            Common.GetElement(locator);


            return GetElement(locator).Text;

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://omayo.blogspot.com/";

            string expectedResult = "Martynas";

            IWebElement inputElement = driver.FindElement(By.XPath("//*[@id=\"textbox1\"]"));
            inputElement.Clear();
            inputElement.SendKeys(expectedResult);

            string actualResult = inputElement.GetAttribute("value");

            Assert.AreEqual(expectedResult, actualResult);



        }

        public static void EnterHtmlFormUserName()
        {

        }

        public static void EnterTextBoxWithPreloadedText()
        {

        }

        public static string GetValueOfTextBoxWithPreloadedText()
        {
            return "???";
        }

        public static string EnterHtmlFormUserNam()
        {
            Common.GetElement

                Driver.GetDriver().FindElement(By.XPath(locator));

            string locator = "//form[@name='form1']/input[@type='text']";
            return Common.GetElementText(locator);


            string expectedResult = "Martynas";

            driver.Url = "https://omayo.blogspot.com/";
            //driver.Navigate().GoToUrl("https://omayo.blogspot.com/"); // kitas budas atsidaryti puslapi

            IWebElement inputElement = driver.FindElement(By.XPath("//form[@name='form1']/input[@type='text']"));

            inputElement.SendKeys(expectedResult);


        }

        public static void EnterFullName(string name)
        {
            string locator = "//*[@ID=\"userName\"]";
            Common.SendKeysToElement(locator, name);
        }
    }
}
