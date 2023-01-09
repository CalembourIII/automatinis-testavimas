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
        private static string maleRadioButtonLocator = "(//input[@value='Male'])[1]"; //kitas XPatch variantas: //*[text()='Radio Button Demo']/following-sibling::div//input[@value='Male']/../
        private static string femaleSingleRadioButtonLocator = "(//input[@value='Female'])[1]";
        private static string getCheckedValueButtonLocator = "//*[@id='buttoncheck']";
        private static string getCheckedValueMessageLocator = "//*[@class='radiobutton']";

        private static string maleGroupRadioButtonLocator = "(//input[@value='Male'])[2]"; // kitas XPatch variantas: //input[@name='gender'][@value='Male']
        private static string femaleGroupRadioButtonLocator = "(//input[@value='Female'])[2]"; // kitas XPatch variantas: //input[@name='gender'][@value='Female']
        private static string AgeGroup1RadioButtonLocator = "//*[@value='0 - 5']";
        private static string AgeGroup2RadioButtonLocator = "//*[@value='5 - 15']";     
        private static string AgeGroup3RadioButtonLocator = "//*[@value='15 - 50']";
        private static string getValuesButtonLocator = "(//*[@type='button'])[3]"; // kitas XPatch variantas: //button(text)
        private static string getValuesMessageLocator = "//*[@class='groupradiobutton']";

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
            Common.ClickElement(femaleSingleRadioButtonLocator);
        }

        public static void ClickGetCheckedValueButton()
        {
            Common.ClickElement(getCheckedValueButtonLocator);
        }

        public static string getCheckedValueMessage()
        {
            return Common.GetElementText(getCheckedValueMessageLocator);
        }

        public static void ClickMaleGroupRadioButton()
        {
            Common.ClickElement(maleGroupRadioButtonLocator);
        }

        public static void ClickFemaleGroupRadioButton()
        {
            Common.ClickElement(femaleGroupRadioButtonLocator);
        }

        public static void ClickAgeGroup1RadioButton()
        {
            Common.ClickElement(AgeGroup1RadioButtonLocator);
        }

        public static void ClickAgeGroup2RadioButton()
        {
            Common.ClickElement(AgeGroup2RadioButtonLocator);
        }

        public static void ClickAgeGroup3RadioButton()
        {
            Common.ClickElement(AgeGroup3RadioButtonLocator);
        }

        public static void ClickgetValuesButton()
        {
            Common.ClickElement(getValuesButtonLocator);
        }

        public static string getValuesMessage()
        {
            return Common.GetElementText(getValuesMessageLocator);
        }
    }
}
