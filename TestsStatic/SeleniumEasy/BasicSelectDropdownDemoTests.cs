using FrameworkStatic.Pages.DemoQA;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.SeleniumEasy;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicSelectDropdownDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            BasicSelectDropdownDemo.Open();
        }

        [TearDown]
        public void CleanUp()
        {
            //Driver.CloseDriver();
        }

        [Test]
        public static void Select_Dropdown()
        {
            string expectedDay = "Monday";
            BasicSelectDropdownDemo.SelectWeekday(expectedDay);
            string result = BasicSelectDropdownDemo.GetDaySelectedMessage();

            Assert.IsTrue(result.Contains(expectedDay));
        }

        [Test]
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

    }
}
