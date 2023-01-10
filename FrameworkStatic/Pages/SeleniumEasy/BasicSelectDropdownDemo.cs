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

        public static void ClickGetAllSelectedButton()
        {
            Common.ClickElement(getAllSelectedButtonLocator);
        }

        public static string GetMultipleSelectedMessage()
        {
            return Common.GetElementText(getMultipleSelectionMessageLocator);
        }
    }
}
