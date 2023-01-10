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
        private static string promptBoxButtonLocator = "//*[@id='promtButton']";
        private static string AlertButtonWithDelayLocator = "//*[@id='timerAlertButton']";
        private static string promptResultMessageLocator = "//*[@id='promptResult']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickPromptAlertBoxButton()
        {
            Common.ClickElement(promptBoxButtonLocator);
        }
        public static void ClickAlertWithDelayButton()
        {
            Common.ClickElement(AlertButtonWithDelayLocator);
        }

        public static void CancelAlert()
        {
            Common.DismissAlert();
        }
        public static void ConfirmAlert()
        {
            Common.WaitForAlertToBePresent();
            Common.AcceptAlert();
        }

        public static bool CheckIfMessageElementIsPresent()
        {
           return Common.CheckIfElementIsPresent(promptResultMessageLocator);
        }

        public static bool CheckIfAlertPresent()
        {
            return Common.CheckIfAlertPresent();
        }
    }
}
