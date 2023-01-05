using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace FrameworkStatic.Pages.DemoQA
{
    public class TextBox
    {
        public static void Open()
        {
            string url = "https://demoqa.com/text-box";
            Driver.OpenPage(url);
        }

        public static string GetHeaderText()
        {
            string locator = "//*[@class=\"main-header\"]";
            return Common.GetElementText(locator);
        }

        public static void EnterFullName(string name)
        {
            string locator = "//*[@ID=\"userName\"]";
            Common.SendKeysToElement(locator, name);
        }
    }
}
