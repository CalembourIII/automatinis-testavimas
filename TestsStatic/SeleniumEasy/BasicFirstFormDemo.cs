using FrameworkStatic.Pages.SeleniumEasy;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.OmayoBlogspot;
using TestsStatic.BaseClasses;

// Leidžia nustatyti kiek paralelinių procesų norime turėti
// Pagal nutylėjimą: branduolių skaičius arba 2 (kuris didesnis)
[assembly: LevelOfParallelism(3)]
namespace TestsStatic.SeleniumEasy
{
    // Šitaip padarome, kad klasėje esantys testai galėtų veikti paraleliai
    [Parallelizable(scope: ParallelScope.Children)]
    internal class BasicFirstFormDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BasicFirstFormDemo.Open();
        }

        [TestCase("Tomas")]
        [TestCase("Paulius")]
        [TestCase("NaN")]
        [Test, Order(4)]
        public void Enter_Message_Text_Get_Span_Value(string expectedResult)
        {
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
