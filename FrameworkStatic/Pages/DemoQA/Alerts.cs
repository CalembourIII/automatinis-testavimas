using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.DemoQA
{
    public class Alerts
    {
        private static string url = "https://demoqa.com/alerts";
        private static string buttonPromptBoxLocator = "//*[@id='promtButton']";
        private static string promptResultMessageLocator = "//*[@id='promptResult']";


        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickPromptAlertBoxButton()
        {
            Common.ClickElement(buttonPromptBoxLocator);
        }

        public static void CancelAlert()
        {
            Common.DismissAlert();
        }

        public static bool CheckIfMessageElementIsPresent()
        {
           return Common.CheckIfElementIsPresent(promptResultMessageLocator);
        }
    }
}
