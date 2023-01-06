using FrameworkStatic.Pages.DemoQA;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsStatic.DemoQA
{
    internal class RadioButtonTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            RadioButton.Open();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.CloseDriver();
        }

        [Test]
        public static void Select_Yes_Button()
        {
            string expectedValue = "Yes";
            RadioButton.YesRadioButtonClick();
            string actualValue = RadioButton.GetMessageSelectedConfirmation();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public static void Select_Impressive_Button()
        {
            string expectedValue = "Impressive";
            RadioButton.ImpressiveRadioButtonClick();
            string actualValue = RadioButton.GetMessageSelectedConfirmation();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public static void Check_If_Button_No_Is_Disabled()
        {
            bool radioButtonNoEnabled = RadioButton.CheckIfButtonNoIsEnabled();

            Assert.AreEqual(false, radioButtonNoEnabled);
        }
    }
}
