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
        public void Enter_Html_Form_User_Name()
        {
            string expectedResult = "Paulius";

            Homepage.EnterHtmlFormUserName(expectedResult);
            string actualResult = Homepage.GetValueOfHtmlFormUserName();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Clear_And_Enter_Text_To_Text_Box_With_Preloaded_Text()
        {
            string expectedResult = "Paulius";

            Homepage.ClearTextBoxWithPreloadedText();
            Homepage.EnterTextToBoxWithPreloadedText(expectedResult);
            string actualResult = Homepage.GetValueOfTextBoxWithPreloadedText();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetFileForUpload()
        {
            string expectedResult = "Driver.cs";

            Homepage.SetFileForUpload();
            string actualResult = Homepage.GetSelectedFileName();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
