using FrameworkStatic.Pages.OmayoBlogspot;
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
    internal class DynamicPropertiesTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            DynamicProperties.Open();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.CloseDriver();
        }

        [Test]
        public void Wait_For_Button_To_Be_Clickable()
        {
            DynamicProperties.WaitForButtonToBeClickable();
        }

        [Test]
        public void Wait_For_Button_To_Change_Color()
        {
            DynamicProperties.WaitForButtonToChangeColor();
        }

        [Test]
        public void Wait_For_Button_To_Be_Visible()
        {
            DynamicProperties.WaitForButtonToBeVisible();
        }
    }
}
