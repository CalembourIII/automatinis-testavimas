using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicFirstFormDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
        private static string InputMessageLocator = "//*[@id=\"user-message\"]";
        private static string buttonShowMessageLocator = "//*[@id='get-input']/button";
        private static string spanMessageLocator = "//*[@id=\"display\"]";
        private static string divFullMessageLocator = "//div[@id=\"user-message\"]";
        private static string enterSum1Locator = "//*[@id=\"sum1\"]";
        private static string enterSum2Locator = "//*[@id=\"sum2\"]";
        private static string getTotalButtonLocator = "//*[@id=\"gettotal\"]/button";
        private static string displayTotalValueLocator = "//*[@id=\"displayvalue\"]";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void EnterMessage(string name)
        {
            Common.SendKeysToElement(InputMessageLocator, name);
        }

        public static void ClickShowMessageButton()
        {
            Common.ClickElement(buttonShowMessageLocator);
        }

        public static string GetValueOfMessage()
        {
            return Common.GetElementText(spanMessageLocator);
        }

        public static string GetValueOfFullMessage()
        {
            return Common.GetElementText(divFullMessageLocator);
        }

        public static void EnterValueToSum1(string value)
        {
            Common.SendKeysToElement(enterSum1Locator, value);
        }
        public static void EnterValueToSum2(string value)
        {
            Common.SendKeysToElement(enterSum2Locator, value);
        }
        public static void ClickGetTotalButton()
        {
            Common.ClickElement(getTotalButtonLocator);
        }
        public static string GetValueOfDisplayTotalValue()
        {
            return Common.GetElementText(displayTotalValueLocator);
        }
    }
}
