using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrameworkStatic.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string value)
        {
            GetElement(locator).SendKeys(value);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
            //return GetElement(locator).GetAttribute("value"); // kitas budas gauti atgal teksta
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static void ClearInputElement(string locator)
        {
            GetElement(locator).Clear();
        }

        internal static void ClickMultipleElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static bool GetCheckboxStatus(string locator)
        {
            return GetElement(locator).Selected;
        }

        internal static List<bool> GetMultipleElementStatus(string locator)
        {
            List<IWebElement> elements = GetElements(locator);
            List<bool> statuses = new List<bool>();

            foreach (IWebElement element in elements)
            {
                statuses.Add(element.Selected);
            }

            return statuses;

        }

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        internal static void WaitForElementAttributeToContainValue(string locator, string attributeName, string value)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(value));
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static bool GetElementEnabledStatus(string locator)
        {
            return GetElement(locator).Enabled;
        }

        internal static void LeftClickElement(string locator)
        {
            IWebElement element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.Click(element);
            actions.Perform();
        }

        internal static void RightClickElement(string locator)
        {
            IWebElement element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.ContextClick(element);
            actions.Perform();
        }

        internal static void DoubleClickElement(string locator)
        {
            IWebElement element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());
            actions.DoubleClick(element);
            actions.Perform();
        }

        internal static SelectElement GetSelectElement(string locator)
        {
            IWebElement element = GetElement(locator);
            return new SelectElement(element);
        }


        internal static void SelectOptionByValue(string selectElementLocator, string value)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);

            selectElement.SelectByValue(value);
        }

        internal static void SelectOptionByText(string selectElementLocator, string optionText)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);

            selectElement.SelectByText(optionText);
        }

        internal static string GetSelectedOptionText(string selectElementLocator)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);

            return selectElement.SelectedOption.Text;
        }

        internal static void MultiSelectByValue(string locator, string value)
        {
            SelectElement selectElement = GetSelectElement(locator);
            //Actions actions = new Actions(Driver.GetDriver());
            //actions.KeyDown(Keys.Control);
            selectElement.SelectByValue(value);
            //actions.Perform();
        }

        internal static void SelectMultipleOptionsByTextUsingAction(string selectStatesMultiSelectLocator, List<string> optionElementLocatorList)
        {
            IWebElement selectElement = GetElement(selectStatesMultiSelectLocator);
            Actions actions = new Actions(Driver.GetDriver());
            List<IWebElement> optionElements = new List<IWebElement>();
            foreach (string optionLocator in optionElementLocatorList)
            {
                optionElements.Add(GetElement(optionLocator));
            }

            actions.ScrollToElement(selectElement);

            actions.KeyDown(Keys.Control);

            foreach(IWebElement element in optionElements)
            {
                actions.Click(element);
            }
            actions.Perform();
        }

        internal static void AcceptAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Accept();
        }
        internal static void DismissAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Dismiss();
        }

        internal static string GetAlertText()
        {
            return Driver.GetDriver().SwitchTo().Alert().Text;
        }

        internal static void SendKeysToAlert(string keys)
        {
            Driver.GetDriver().SwitchTo().Alert().SendKeys(keys);
        }

        internal static bool CheckIfElementIsPresent(string locator)
        {
            try
            {
                GetElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal static void SelectMultipleOptionsByText(string selectElementLocator, List<string> optionTextList)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);
            foreach (string optionText in optionTextList)
            {
                selectElement.SelectByText(optionText);
            }
        }

        internal static void SelectMultipleOptionsByTextUsingActions(string selectElementLocator, List<string> optionElementLocatorList)
        {
            IWebElement selectElement = GetElement(selectElementLocator);

            // Iš lokatorių sąrašo 'pasigaminame' elementų sąrašą
            List<IWebElement> optionElements = new List<IWebElement>();
            foreach (string optionLocator in optionElementLocatorList)
            {
                optionElements.Add(GetElement(optionLocator));
            }

            // Atliekame elementų pažymėjimą
            Actions actions = new Actions(Driver.GetDriver());
            actions.ScrollToElement(selectElement); // Turime 'nuscrolinti' prie select elemento (kažkodėl), kad būtų atvaizduota ir pirma reikšmė
            actions.KeyDown(Keys.Control);
            foreach (IWebElement element in optionElements)
            {
                actions.Click(element);
            }
            actions.Perform();
        }
    }
}
