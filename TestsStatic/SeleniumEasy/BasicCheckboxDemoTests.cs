using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicCheckboxDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            BasicCheckboxDemo.Open();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.CloseDriver();
        }

        [Test]
        public static void Click_Single_Checkbox()
        {
            string expectedResult = "Success - Check box is checked";
            BasicCheckboxDemo.ClickSingleCheckbox();
            string actualResult = BasicCheckboxDemo.GetSuccessMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Click_Multiple_Checkboxes()
        {
            string expectedButtonText = "Uncheck All";

            BasicCheckboxDemo.ClickEachCheckbox();

            string actualCheckboxText = BasicCheckboxDemo.GetCheckAllMessage();

            Assert.AreEqual(expectedButtonText, actualCheckboxText);
        }

        [Test]
        public static void Click_Check_All_Checkboxes()
        {

            BasicCheckboxDemo.ClickCheckAllButton();
            bool statusCheckbox1 = BasicCheckboxDemo.GetCheckbox1Status();
            bool statusCheckbox2 = BasicCheckboxDemo.GetCheckbox2Status();
            bool statusCheckbox3 = BasicCheckboxDemo.GetCheckbox3Status();
            bool statusCheckbox4 = BasicCheckboxDemo.GetCheckbox4Status();

            string actualCheckboxText = BasicCheckboxDemo.GetCheckAllMessage();

            Assert.IsTrue(statusCheckbox1);
            Assert.IsTrue(statusCheckbox2);
            Assert.IsTrue(statusCheckbox3);
            Assert.IsTrue(statusCheckbox4);
        }
    }
}
