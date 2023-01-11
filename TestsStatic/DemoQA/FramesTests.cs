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
    internal class FramesTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Frames.Open();
        }

        [Test]
        public void ReadHeadingInsideIframe()
        {
            string expectedHeadingText = "This is a sample page";

            string actualHeadingText = Frames.GetIframeHeadingText();

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }
    }
}
