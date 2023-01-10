using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class JavascriptAlertBoxDemo
    {
        private static string url = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";
        private static string sectionLocator = "//*[contains(@class,'panel-primary')]";
        private static string buttonAlertBoxLocator = $"({sectionLocator})[1]//button";
        private static string buttonConfirmAlertBoxLocator = $"({sectionLocator})[2]//button";
        private static string buttonPromptAlertBoxLocator = $"({sectionLocator})[3]//button";
        private static string alertMessageLocator = "//*[@id='confirm-demo']";
        private static string promptMessageLocator = "//*[@id='prompt-demo']";





        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickAlertBoxButton()
        {
            Common.ClickElement(buttonAlertBoxLocator);
        }
        public static void ClickConfirmAlertBoxButton()
        {
            Common.ClickElement(buttonConfirmAlertBoxLocator);
        }
        public static void ClickPromptAlertBoxButton()
        {
            Common.ClickElement(buttonPromptAlertBoxLocator);
        }

        public static void ConfirmAlert()
        {
            Common.AcceptAlert();
        }
        public static void CancelAlert()
        {
            Common.DismissAlert();
        }

        public static string GetAlertText()
        {
            return Common.GetAlertText();
        }

        public static string GetAlertMessage()
        {
            return Common.GetElementText(alertMessageLocator);
        }

        public static string GetPromptMessage()
        {
            return Common.GetElementText(promptMessageLocator);
        }
        public static void EnterTextToPromptAlert(string name)
        {
            Common.SendKeysToAlert(name);
        }
    }
}
