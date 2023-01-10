using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicSelectDropdownDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        private static string selectElementLocator = "//*[@id='select-demo']";
        private static string messageWeekdayLocator = "//*[@class='selected-value']";
        private static string selectStatesMultiSelectLocator = "//*[@id='multi-select']";
        private static string firstSelectedButtonLocator = "//*[@id='printMe']";
        private static string getAllSelectedButtonLocator = "//*[@id='printAll']";
        private static string getMultipleSelectionMessageLocator = "//*[@class='getall-selected']";
        private static string multiSelectElementLocator = "//*[@id='multi-select']";
        private static string buttonGetAllSelectedLocator = "//*[@id='printAll']";
        private static string multiSelectMessageLocator = "//*[@class='getall-selected']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void SelectWeekday(string weekday)
        {
            Common.SelectOptionByValue(selectElementLocator, weekday);
        }

        public static string GetDaySelectedMessage()
        {
            return Common.GetElementText(messageWeekdayLocator);
        }

        public static void SelectMultiElements(string selectedState)
        {
            Common.MultiSelectByValue(selectStatesMultiSelectLocator, selectedState);
        }

        public static void ClickFirstSelectedButton()
        {
            Common.ClickElement(firstSelectedButtonLocator);
        }

        public static string GetMultipleSelectedMessage()
        {
            return Common.GetElementText(getMultipleSelectionMessageLocator);
        }

        public static void GetAllSelectedButton()
        {
            Common.ClickElement(getAllSelectedButtonLocator);
        }

        public static void ClickGetAllSelectedButton()
        {
            Common.ClickElement(buttonGetAllSelectedLocator);
        }

        public static string GetMultiSelectMessage()
        {
            return Common.GetElementText(multiSelectMessageLocator);
        }

        private static List<string> GenerateOptionElementLocatorList(List<string> optionTextList)
        {
            List<string> locators = new List<string>();
            foreach (string optionText in optionTextList)
            {
                locators.Add($"//*[text()='{optionText}']");
            }
            return locators;
        }

        public static void SelectMultipleOptionsByTextUsingActions(List<string> selectionValues)
        {
            List<string> optionElementLocatorList = GenerateOptionElementLocatorList(selectionValues);
            Common.SelectMultipleOptionsByTextUsingActions(multiSelectElementLocator, optionElementLocatorList);
        }

        public static void SelectMultipleOptionsByText(List<string> selectionValues)
        {
            {
                Common.SelectMultipleOptionsByText(multiSelectElementLocator, selectionValues);
            }
        }
    }
}
