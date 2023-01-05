using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsStatic.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            TextBox.Open();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.CloseDriver();
        }

        [Test]
        public void Demoqa_Input()
        {

            string expectedResult = "Text Box";
            string actualResult = TextBox.GetHeaderText();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
