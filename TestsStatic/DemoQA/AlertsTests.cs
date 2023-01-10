using FrameworkStatic.Pages.SeleniumEasy;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.DemoQA;

namespace TestsStatic.DemoQA
{
    internal class AlertsTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Alerts.Open();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.CloseDriver();
        }

        [Test]
        public static void Prompt_Box_Default_Value_Cancel()
        {
            bool messageElementIsPresent = false;
            Alerts.ClickPromptAlertBoxButton();
            Alerts.CancelAlert();
            bool messageElementActualPresence = Alerts.CheckIfMessageElementIsPresent();

            Assert.AreEqual(messageElementIsPresent, messageElementActualPresence);
        }


    }
}
