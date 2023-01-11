using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsStatic.BaseClasses;

namespace TestsStatic.DemoQA
{
    internal class ButtonsTests : BaseTestSingleSession
    {
        [OneTimeSetUp]
        public void Open()
        {
            Buttons.Open();
        }

        [Test]
        public void Click_Left_Button()
        {
            string expectedMessage = "You have done a dynamic click";

            Buttons.LeftClickButton();
            string actualMessage = Buttons.GetLeftClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void Click_Right_Button()
        {
            string expectedMessage = "You have done a right click";

            Buttons.RightClickButton();
            string actualMessage = Buttons.GetRightClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void Double_Click_Button()
        {
            string expectedMessage = "You have done a double click";

            Buttons.DoubleClickButton();
            string actualMessage = Buttons.GetDoubleClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
