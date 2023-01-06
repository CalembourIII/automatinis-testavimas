using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicCheckboxDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-checkbox-demo.html";
        private static string singleCheckboxLocator = "//*[@id=\"isAgeSelected\"]";
        private static string multipleCheckboxesLocator = "//*[@class='cb1-element']";
        private static string successMessageLocator = "//*[@id=\"txtAge\"]";
        private static string checkAllButtonLocator = "//*[@id=\"check1\"]";
        private static string multipleCheckbox1Locator = "(//*[@class='cb1-element'])[1]";
        private static string multipleCheckbox2Locator = "(//*[@class='cb1-element'])[2]";
        private static string multipleCheckbox3Locator = "(//*[@class='cb1-element'])[3]";
        private static string multipleCheckbox4Locator = "(//*[@class='cb1-element'])[4]";


        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickSingleCheckbox()
        {
            Common.ClickElement(singleCheckboxLocator);
        }

        public static string GetSuccessMessage()
        {
        return Common.GetElementText(successMessageLocator);
        }

        public static void ClickEachCheckbox()
        {
            Common.ClickMultipleElements(multipleCheckboxesLocator);
        }

        public static string GetCheckAllMessage()
        {
            return Common.GetAttributeValue(checkAllButtonLocator, "value");
        }

        public static void ClickCheckAllButton()
        {
            Common.ClickElement(checkAllButtonLocator);
        }

        public static bool GetCheckbox1Status()
        {
            return Common.GetCheckboxStatus(multipleCheckbox1Locator);
        }
        public static bool GetCheckbox2Status()
        {
            return Common.GetCheckboxStatus(multipleCheckbox2Locator);
        }

        public static bool GetCheckbox3Status()
        {
            return Common.GetCheckboxStatus(multipleCheckbox3Locator);
        }

        public static bool GetCheckbox4Status()
        {
            return Common.GetCheckboxStatus(multipleCheckbox4Locator);
        }
        public static void ClickMultipleCheckbox1()
        {
            Common.ClickElement(multipleCheckbox1Locator);
        }

        public static void ClickMultipleCheckbox2()
        {
            Common.ClickElement(multipleCheckbox2Locator);
        }

        public static void ClickMultipleCheckbox3()
        {
            Common.ClickElement(multipleCheckbox3Locator);
        }

        public static void ClickMultipleCheckbox4()
        {
            Common.ClickElement(multipleCheckbox4Locator);
        }

    }
}
