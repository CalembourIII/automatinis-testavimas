using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.DemoQA
{
    public class BrowserWindows
    {
        private static string url = "https://demoqa.com/browser-windows";
        private static string buttonNewTabLocator = "//*[@id='tabButton']";
        private static string buttonNewWindowLocator = "//*[@id='windowButton']";
        private static string headerTextLocator = "//*[@id='sampleHeading']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        private static void SwitchWindowFromCurrent()
        {
            string currentHandle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromParentWindowByHandle(currentHandle);
        }

        public static void ClickNewTabButton()
        {
            Common.ClickElement(buttonNewTabLocator);
            SwitchWindowFromCurrent();
        }

        public static void ClickNewWindowButton()
        {
            Common.ClickElement(buttonNewWindowLocator);
            SwitchWindowFromCurrent();
        }

        public static string GetHeadingText()
        {
            return Common.GetElementText(headerTextLocator);
        }
    }
}
