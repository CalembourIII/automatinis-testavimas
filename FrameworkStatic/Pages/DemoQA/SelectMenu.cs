using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.DemoQA
{
    public class SelectMenu
    {
        private static string url = "https://demoqa.com/select-menu";
        private static string oldStyleDropdownLocator = "//*[@id='oldSelectMenu']";
        private static string selectValueDropdownLocator = "//*[@id='withOptGroup']";
        private static string selectionOfSelectValueDropdown = "//*[@id='withOptGroup']/div/div[1]/div[1]";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void SelectColor2(string expectedColor)
        {
            Common.SelectOptionByText(oldStyleDropdownLocator, expectedColor);
        }

        public static string GetSelectedColor()
        {
            return Common.GetSelectedOptionText(oldStyleDropdownLocator);
        }

        public static void ExpandSelectValueDropdown()
        {
            Common.ClickElement(selectValueDropdownLocator);
        }

        public static void SelectValueFromSelectValueDropdown(string value)
        {
            string optionByTextLocator = $"//*[text()='{value}']";
            Common.ClickElement(optionByTextLocator);
        }

        public static string GetSelectedValueOfSelectValueDropdown()
        {
            return Common.GetElementText(selectionOfSelectValueDropdown);
        }
    }
}
