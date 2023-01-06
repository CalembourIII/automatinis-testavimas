using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.DemoQA
{
    public class DynamicProperties
    {
        private static string url = "https://demoqa.com/dynamic-properties";
        private static string ButtonToBeClickableLocator = "//*[@id='enableAfter']";
        private static string ButtonToChangeColorLocator = "//*[@id='colorChange']";
        private static string buttonToBePresentLocator = "//*[@id='visibleAfter']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void WaitForButtonToBeClickable()
        {
            Common.WaitForElementToBeClickable(ButtonToBeClickableLocator);
        }

        public static void WaitForButtonToChangeColor()
        {
            Common.WaitForElementAttributeToContainValue(ButtonToChangeColorLocator, "class", "text-danger");
        }

        public static void WaitForButtonToBeVisible()
        {
            Common.WaitForElementToBeVisible(buttonToBePresentLocator);
        }
    }
}
