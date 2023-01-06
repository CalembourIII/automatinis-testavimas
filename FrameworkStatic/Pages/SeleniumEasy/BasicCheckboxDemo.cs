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
            throw new NotImplementedException();
        }

        public static bool GetCheckbox2Status()
        {
            throw new NotImplementedException();
        }

        public static bool GetCheckbox3Status()
        {
            throw new NotImplementedException();
        }

        public static bool GetCheckbox4Status()
        {
            throw new NotImplementedException();
        }
    }
}
