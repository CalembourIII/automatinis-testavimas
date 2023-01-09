using FrameworkStatic.Pages.SeleniumEasy;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.DemoQA;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicRadioButtonDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            BasicRadioButtonDemo.Open();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.CloseDriver();
        }

        [Test]
        public static void Select_Male_Button()
        {
            string expectedValue = "Radio button 'Male' is checked";
            BasicRadioButtonDemo.ClickMaleRadioButton();
            BasicRadioButtonDemo.ClickGetCheckedValueButton();
            string actualValue = BasicRadioButtonDemo.getCheckedValueMessage();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public static void Select_Male_Age_15_50_Button()
        {
            string expectedValue = "Sex : Male\r\nAge group: 15 - 50";

            BasicRadioButtonDemo.ClickMaleGroupRadioButton();
            BasicRadioButtonDemo.ClickAgeGroup3RadioButton();
            BasicRadioButtonDemo.ClickgetValuesButton();
            string actualValue = BasicRadioButtonDemo.getValuesMessage();

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
