using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.DOMSnapshot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestai
{
    public class Class1
    {
        [Test]
        public void Testas1()
        {
            IWebDriver driver = new ChromeDriver();

            string expectedOutput = "Labas";

            driver.Url = "https://demoqa.com/text-box";
            IWebElement inputElement = driver.FindElement(By.XPath("//*[@ID=\"userName\"]"));
            inputElement.SendKeys("Labas");

            string actualOutput = inputElement.Text;

            Assert.AreEqual(expectedOutput, actualOutput);

            driver.Quit();



            //driver.FindElement(By.CssSelector("#userName"));
            //driver.FindElement(By.Id("userName"));




            //driver.FindElement(By.XPath(""));
            //driver.FindElement(By.CssSelector(""));
            //driver.FindElement(By.Id(""));
        }

        [Test]
        public void Testas2()
        {
            IWebDriver driver = new ChromeDriver();

            string expectedResult = "Text Box";

            driver.Url = "https://demoqa.com/text-box";
            IWebElement inputElement = driver.FindElement(By.XPath("//*[@class='main-header']"));

            string actualResult = inputElement.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void Testas3()
        {
            IWebDriver driver = new ChromeDriver();

            string expectedResult = "Martynas";

            driver.Url = "https://omayo.blogspot.com/";
            //driver.Navigate().GoToUrl("https://omayo.blogspot.com/"); // kitas budas atsidaryti puslapi

            IWebElement inputElement = driver.FindElement(By.XPath("//form[@name='form1']/input[@type='text']"));

            inputElement.SendKeys(expectedResult);

            string actualResult = inputElement.GetAttribute("value");

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void Testas4()
        {
            IWebDriver driver = new ChromeDriver();

            string expectedResult = "Martynas";

            driver.Url = "https://omayo.blogspot.com/";
            //driver.Navigate().GoToUrl("https://omayo.blogspot.com/"); // kitas budas atsidaryti puslapi

            IWebElement inputElement = driver.FindElement(By.XPath("//*[@id=\"textbox1\"]"));
            inputElement.Clear();
            inputElement.SendKeys(expectedResult);

            string actualResult = inputElement.GetAttribute("value");

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

    }
}
