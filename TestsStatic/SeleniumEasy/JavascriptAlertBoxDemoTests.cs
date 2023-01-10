using FrameworkStatic.Pages.SeleniumEasy;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsStatic.SeleniumEasy
{
    internal class JavascriptAlertBoxDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            JavascriptAlertBoxDemo.Open();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.CloseDriver();
        }

        [Test]
        public static void Test_Simple_Alert()
        {
            string expectedResult = "I am an alert box!";

            JavascriptAlertBoxDemo.ClickAlertBoxButton();
            string actualResult = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.ConfirmAlert();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test_Confirm_Alert_Ok()
        {
            string expectedResult = "You pressed OK!";

            JavascriptAlertBoxDemo.ClickConfirmAlertBoxButton();
            JavascriptAlertBoxDemo.ConfirmAlert();
            string actualResult = JavascriptAlertBoxDemo.GetAlertMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test_Confirm_Alert_Cancel()
        {
            string expectedResult = "You pressed Cancel!";

            JavascriptAlertBoxDemo.ClickConfirmAlertBoxButton();
            JavascriptAlertBoxDemo.CancelAlert();
            string actualResult = JavascriptAlertBoxDemo.GetAlertMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test_Prompt_Alert_Ok()
        {
            string expectedResult = "You have entered 'Enter name' !";

            JavascriptAlertBoxDemo.ClickPromptAlertBoxButton();
            JavascriptAlertBoxDemo.ConfirmAlert();
            string actualResult = JavascriptAlertBoxDemo.GetPromptMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test_Prompt_Alert_Cancel()
        {
            string expectedResult = "";

            JavascriptAlertBoxDemo.ClickPromptAlertBoxButton();
            JavascriptAlertBoxDemo.CancelAlert();
            string actualResult = JavascriptAlertBoxDemo.GetPromptMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void Test_Prompt_Alert_With_Entered_Text()
        {
            string expectedResult = "Paulius";

            JavascriptAlertBoxDemo.ClickPromptAlertBoxButton();
            JavascriptAlertBoxDemo.EnterTextToPromptAlert(expectedResult);
            JavascriptAlertBoxDemo.ConfirmAlert();
            string actualResult = JavascriptAlertBoxDemo.GetPromptMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
