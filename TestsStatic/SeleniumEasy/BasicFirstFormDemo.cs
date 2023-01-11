using FrameworkStatic.Pages.SeleniumEasy;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.OmayoBlogspot;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicFirstFormDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            BasicFirstFormDemo.Open();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.CloseDriver();
        }

        [Test, Order(4)]
        public void Enter_Message_Text_Get_Span_Value()
        {
            string expectedResult = "Paulius";

            BasicFirstFormDemo.EnterMessage(expectedResult);
            BasicFirstFormDemo.ClickShowMessageButton();

            string actualResult = BasicFirstFormDemo.GetValueOfMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(2)]
        public void Enter_Message_Text_Get_Full_Value()
        {
            string message = "Paulius";
            string expectedResult = $"Your Message: {message}";

            BasicFirstFormDemo.EnterMessage(message);
            BasicFirstFormDemo.ClickShowMessageButton();

            string actualResult = BasicFirstFormDemo.GetValueOfFullMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(1)]
        public void Enter_Values_To_Sum_Get_Total_Value()
        {
            string expectedResult = "10";

            BasicFirstFormDemo.EnterValueToSum1("5");
            BasicFirstFormDemo.EnterValueToSum2("5");
            BasicFirstFormDemo.ClickGetTotalButton();

            string actualResult = BasicFirstFormDemo.GetValueOfDisplayTotalValue();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(3)]
        public void Enter_Values_To_Sum_Check_NaN()
        {
            string expectedResult = "NaN";

            BasicFirstFormDemo.ClickGetTotalButton();

            string actualResult = BasicFirstFormDemo.GetValueOfDisplayTotalValue();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
