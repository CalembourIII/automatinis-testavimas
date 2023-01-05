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
            //Driver.CloseDriver();
        }

        [Test]
        public static void Click_Single_Checkbox()
        {
            string expectedResult = "Success - Check box is checked";
            BasicCheckboxDemo.ClickSingleCheckbox();
            string actualResult = BasicCheckboxDemo.GetSuccessMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
