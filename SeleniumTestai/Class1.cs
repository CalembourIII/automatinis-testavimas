using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        public void Testas()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            driver.Manage().
            
        }
    }
}
