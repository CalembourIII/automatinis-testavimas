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
    }
}
