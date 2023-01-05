using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrameworkStatic.Pages.OmayoBlogspot
{
    public class Homepage
    {

        private static string htmlFormUserNameLocator = "//form[@name='form1']/input[@type='text']"; // lokatorius apsirasau klases virsuj, po to pernaudoju
        private static string textBoxWithpreloadedTextLocator = "//*[@id=\"textbox1\"]";

        public static void Open()
        {
            string url = "https://omayo.blogspot.com/";
            Driver.OpenPage(url);
        }

        public static void EnterHtmlFormUserName(string name)
        {
            string locator = "//form[@name='form1']/input[@type='text']";
            Common.SendKeysToElement(locator, name);
        }

        public static string GetValueOfHtmlFormUserName()
        {
            string locator = "//form[@name='form1']/input[@type='text']";
            return Common.GetAttributeValue(locator, "value");
        }
        public static void ClearTextBoxWithPreloadedText()
        {
            string locator = "//*[@id=\"textbox1\"]";
            Common.ClearInputElement(locator);
        }

        public static void EnterTextToBoxWithPreloadedText(string value)
        {
            string locator = "//*[@id=\"textbox1\"]";
            Common.SendKeysToElement(locator, value);
        }

        public static string GetValueOfTextBoxWithPreloadedText()
        {
            string locator = "//*[@id=\"textbox1\"]";
            return Common.GetAttributeValue(locator, "value");
        }
    }
}
