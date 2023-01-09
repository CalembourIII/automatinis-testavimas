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
    }
}
