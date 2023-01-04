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
    public class InputElements
    {

        // $x("//div[@id='user-message']") - kai kazko nerandi, elemento puslapyje, kad gautusi geras xPath,
        // tai gali per console surinkti ir bandyti ieskoti

        //driver.FindElement(By.CssSelector("#userName"));
        //driver.FindElement(By.Id("userName"));

        //driver.FindElement(By.XPath(""));
        //driver.FindElement(By.CssSelector(""));
        //driver.FindElement(By.Id(""));

        [Test]
        public void Demoqa_TextBox()
        {
            IWebDriver driver = new ChromeDriver();

            string expectedOutput = "Labas";

            driver.Url = "https://demoqa.com/text-box";
            IWebElement inputElement = driver.FindElement(By.XPath("//*[@ID=\"userName\"]"));
            inputElement.SendKeys("Labas");

            string actualOutput = inputElement.Text; // su inputElement nepavyksta. Cia reiktu naudoti: inputElement.GetAttribute("value");

            Assert.AreEqual(expectedOutput, actualOutput);

            driver.Quit();
        }

        [Test]
        public void Demoqa_TextBox2()
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
        public void Omayo_Single_Message1()
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
        public void Omayo_Single_Message2()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://omayo.blogspot.com/";

            string expectedResult = "Martynas";

            IWebElement inputElement = driver.FindElement(By.XPath("//*[@id=\"textbox1\"]"));
            inputElement.Clear();
            inputElement.SendKeys(expectedResult);

            string actualResult = inputElement.GetAttribute("value");

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void Selenium_Easy_Single_Message()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string expectedResult = "Martynas";

            IWebElement inputMessage = driver.FindElement(By.XPath("//*[@id=\"user-message\"]"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            IWebElement spanMessage = driver.FindElement(By.XPath("//*[@id=\"display\"]"));

            inputMessage.SendKeys(expectedResult);
            buttonShowMessage.Click();
            string actualResult = spanMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void Selenium_Easy_Full_Message()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string message = "Paulius";
            string expectedResult = $"Your Message: {message}";

            IWebElement inputMessage = driver.FindElement(By.XPath("//*[@id=\"user-message\"]"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            IWebElement fullMessage = driver.FindElement(By.XPath("//div[@id=\"user-message\"]"));

            inputMessage.SendKeys(message);
            buttonShowMessage.Click();
            string actualResult = fullMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void Selenium_Two_Input_Fields()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string inputValue1 = "5";
            string inputValue2 = "5";
            string expectedResult = "10";

            IWebElement inputNumber1 = driver.FindElement(By.Id("sum1")); // Cia su Id bandom rasti elementa, ne su XPatch
            IWebElement inputNumber2 = driver.FindElement(By.Id("sum2"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id=\"gettotal\"]/button"));
            IWebElement fullMessage = driver.FindElement(By.XPath("//*[@id=\"displayvalue\"]"));

            inputNumber1.SendKeys(inputValue1);
            inputNumber2.SendKeys(inputValue2);
            buttonGetTotal.Click();
            string actualResult = fullMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void Selenium_Two_Input_Fields_NaN()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string inputValue1 = "";
            string inputValue2 = "";
            string expectedResult = "NaN"; // Nan reiskia "Not a Number" - tikrinsim ar rezultatas - ne skaicius

            IWebElement inputNumber1 = driver.FindElement(By.Id("sum1")); // Cia su Id bandom rasti elementa, ne su XPatch
            IWebElement inputNumber2 = driver.FindElement(By.Id("sum2"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id=\"gettotal\"]/button"));
            IWebElement fullMessage = driver.FindElement(By.XPath("//*[@id=\"displayvalue\"]"));

            inputNumber1.SendKeys(inputValue1);
            inputNumber2.SendKeys(inputValue2);
            buttonGetTotal.Click();
            string actualResult = fullMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

    }
}
