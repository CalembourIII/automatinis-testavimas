using FrameworkStatic.Pages.DemoQA;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.SeleniumEasy;

namespace TestsStatic.DemoQA
{
    internal class SelectMenuTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            SelectMenu.Open();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.CloseDriver();
        }

        [Test]
        public static void Select_Old_Style_Menu()
        {
            string expectedColor = "Purple";
            SelectMenu.SelectColor2(expectedColor);
            string actualColor= SelectMenu.GetSelectedColor();

            Assert.AreEqual(expectedColor, actualColor);
        }

        [Test]
        public static void Select_Value_Dropdown()
        {
            string expectedSelection = "Group 2, option 1";

            SelectMenu.ExpandSelectValueDropdown();
            SelectMenu.SelectValueFromSelectValueDropdown(expectedSelection);
            string actualSelection = SelectMenu.GetSelectedValueOfSelectValueDropdown();

            Assert.AreEqual(@expectedSelection, actualSelection);
        }

    }
}
