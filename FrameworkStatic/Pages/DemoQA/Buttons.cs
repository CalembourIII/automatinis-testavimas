using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.DemoQA
{
    public class Buttons
    {
        private static string url = "https://demoqa.com/buttons";
        private static string doubleClickMeButtonLocator = "//*[@id='doubleClickBtn']";
        private static string rightClickMeButtonLocator = "//*[@id='rightClickBtn']";
        private static string clickMeButtonLocator = "//*[text()='Click Me']";
        private static string doubleClickMeButtonMessageLocator = "//*[@id='doubleClickMessage']";
        private static string rightClickMeButtonMessageLocator = "//*[@id='rightClickMessage']";
        private static string clickMeButtonMessageLocator = "//*[@id='dynamicClickMessage']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void DoubleClickButton()
        {
            Common.DoubleClickElement(doubleClickMeButtonLocator);
        }

        public static void RightClickButton()
        {
            Common.RightClickElement(rightClickMeButtonLocator);
        }

        public static void LeftClickButton()
        {
            Common.LeftClickElement(clickMeButtonLocator);
        }

        public static string GetDoubleClickMessage()
        {
            return Common.GetElementText(doubleClickMeButtonMessageLocator);
        }
        public static string GetRightClickMessage()
        {
            return Common.GetElementText(rightClickMeButtonMessageLocator);
        }

        public static string GetLeftClickMessage()
        {
            return Common.GetElementText(clickMeButtonMessageLocator);
        }
    }
}
