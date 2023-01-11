using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsStatic.BaseClasses;

namespace TestsStatic.DemoQA
{
    internal class BrowserWindowsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BrowserWindows.Open();
        }

        [Test]
        public void Click_New_Tab_Button()
        {
            string expectedHeadingText = "This is a sample page";

            BrowserWindows.ClickNewTabButton();
            string actualHeadingText = BrowserWindows.GetHeadingText();

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }

        [Test]
        public void Click_New_Window_Button()
        {
            string expectedHeadingText = "This is a sample page";

            BrowserWindows.ClickNewWindowButton();
            string actualHeadingText = BrowserWindows.GetHeadingText();

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }
    }
}
