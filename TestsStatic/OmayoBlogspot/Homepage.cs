using FrameworkStatic.Pages.OmayoBlogspot;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.DemoQA;

namespace TestsStatic.OmayoBlogspot
{
    internal class HomepageTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Homepage.Open();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.CloseDriver();
        }

        [Test]
        public void Omayo_EnterHtmlFormUserName()
        {

            string expectedResult = "Paulius";

            Homepage.EnterHtmlFormUserName("Paulius");

            string actualResult = Homepage.GetValueOfHtmlFormUserName();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Omayo_EnterTextToBoxWithPreloadedText()
        {
            string expectedResult = "Paulius";

            Homepage.ClearTextBoxWithpreloadedText();
            Homepage.EnterTextToBoxWithPreloadedText("Paulius");

            string actualResult = Homepage.GetValueOfTextBoxWithPreloadedText();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
