using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.DemoQA
{
    public class RadioButton
    {
        private static string url = "https://demoqa.com/radio-button";
        private static string yesButtonLocator = "//*[@for='yesRadio']";
        private static string impressiveButtonLocator = "//*[@for='impressiveRadio']";
        private static string noButtonLocator = "//*[@id='noRadio']";
        private static string spanTextSuccessLocator = "//*[contains(@class,'text-success')]";

        public static void Open()
        {
            Driver.OpenPage(url);
        }
        public static void YesRadioButtonClick()
        {
            Common.ClickElement(yesButtonLocator);
        }

        public static void ImpressiveRadioButtonClick()
        {
            Common.ClickElement(impressiveButtonLocator);
        }

        public static void NoRadioButtonClick()
        {
            Common.ClickElement(noButtonLocator);
        }

        public static string GetMessageSelectedConfirmation()
        {
            return Common.GetElementText(spanTextSuccessLocator);
        }

        public static bool CheckIfButtonNoIsEnabled()
        {
           return Common.GetElementEnabledStatus(noButtonLocator);
        }
    }
}
