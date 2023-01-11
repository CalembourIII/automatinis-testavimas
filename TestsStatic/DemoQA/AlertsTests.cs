using FrameworkStatic.Pages.SeleniumEasy;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.DemoQA;
using System.Threading;
using TestsStatic.BaseClasses;

namespace TestsStatic.DemoQA
{
    internal class AlertsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Alerts.Open();
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

        [Test]
        public static void Alert_With_Wait()
        {
            bool expectedAlertPresenceResult = false;
            Alerts.ClickAlertWithDelayButton();
            Alerts.ConfirmAlert();
            bool actualAlertPresence = Alerts.CheckIfAlertPresent();

            Assert.AreEqual(expectedAlertPresenceResult, actualAlertPresence);
        }
    }
}
