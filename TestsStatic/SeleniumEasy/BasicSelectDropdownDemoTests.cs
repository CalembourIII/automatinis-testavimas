using FrameworkStatic.Pages.DemoQA;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework.Interfaces;
using TestsStatic.BaseClasses;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicSelectDropdownDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BasicSelectDropdownDemo.Open();
        }

        [Test]
        public static void Select_Dropdown()
        {
            string expectedDay = "Monday";
            BasicSelectDropdownDemo.SelectWeekday(expectedDay);
            string result = BasicSelectDropdownDemo.GetDaySelectedMessage();

            Assert.IsTrue(result.Contains(expectedDay));
        }

        [Test] // sitas mano paties parasytas neveikia, nes veliau prie Common naudoju selectElement ir Actions - taip tiesiog neveikia :/
        public void ValidateMultipleSelection()
        {
            string expectedResult = "First selected option is : Florida";


            List<string> selectedStates = new List<string> { "Florida", "New York", "Texas" };
            foreach (string state in selectedStates)
            {
                BasicSelectDropdownDemo.SelectMultiElements(state);
            }

            BasicSelectDropdownDemo.ClickFirstSelectedButton();
            string actualResult = BasicSelectDropdownDemo.GetMultipleSelectedMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Šis testas pažymi kelis Select elemento Option elementus
        /// Tam naudojamos Selenium SelectElement klasės pagalbinės funkcijos 
        /// Tačiau, nors reikšmės vizualiai būna pažymėtos, 
        /// paspaudus mygtuką Get All Selected, grąžinama tik viena reikšmė
        /// </summary>
        [Test]
        public void MultiSelectUsingSelect()
        {
            List<string> selectionValues = new List<string> { "New York", "Florida", "Texas" };
            string expectedMessage = $"{selectionValues[0]},{selectionValues[1]},{selectionValues[2]}";

            BasicSelectDropdownDemo.SelectMultipleOptionsByText(selectionValues);
            BasicSelectDropdownDemo.ClickGetAllSelectedButton();
            string actualMessage = BasicSelectDropdownDemo.GetMultiSelectMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage),
                $"Expected '{expectedMessage}' in '{actualMessage}'");
        }

        /// <summary>
        /// Šis testas pažymi kelis Select elemento Option elementus
        /// Tam naudojam Selenium Actions klasė
        /// POM dalyje kiekvienai iš Option reikšmių pagaminamas Xpath lokatorius
        /// Xpath lokatoriai naudojami paspausti ant elementų naudojantis Actions klase
        /// Jeigu prieš pradedant žymėti elementus nėra 'nuscrolinama' prie pačio select elemento
        /// tuomet pirma reikšmė paspaudus mygtuką Get All Selected būna negrąžinama
        /// </summary>
        [Test]
        public void MultiSelectUsingActions()
        {
            List<string> selectionValues = new List<string> { "New York", "Florida", "Texas" };
            string expectedMessage = $"{selectionValues[0]},{selectionValues[1]},{selectionValues[2]}";

            BasicSelectDropdownDemo.SelectMultipleOptionsByTextUsingActions(selectionValues);
            BasicSelectDropdownDemo.ClickGetAllSelectedButton();
            string actualMessage = BasicSelectDropdownDemo.GetMultiSelectMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage),
                $"Expected '{expectedMessage}' in '{actualMessage}'");
        }

    }
}
