using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicRadioButtonDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-radiobutton-demo.html";
        private static string maleRadioButtonLocator = "(//input[@value='Male'])[1]";
        private static string femaleRadioButtonLocator = "(//input[@value='Female'])[1]";
        private static string getCheckedValueButtonLocator = "//*[@id='buttoncheck']";
        private static string getCheckedValueMessageLocator = "//*[@class='radiobutton']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickMaleRadioButton()
        {
            Common.ClickElement(maleRadioButtonLocator);
        }

        public static void ClickFemaleRadioButton()
        {
            Common.ClickElement(femaleRadioButtonLocator);
        }

        public static void ClickGetCheckedValueButton()
        {
            Common.ClickElement(getCheckedValueButtonLocator);
        }
        public static string getCheckedValueMessage()
        {
            return Common.GetElementText(getCheckedValueMessageLocator);
        }
    }
}
