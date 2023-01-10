using FrameworkStatic.Pages.OmayoBlogspot;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkStatic.Pages.Facebook;

namespace TestsStatic.Facebook
{
    internal class LoginTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Login.Open();
            Login.CloseCookies();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.CloseDriver();
        }

        [Test]
        public void LoginTest()
        {
            string userEmail = "email";
            string userPassword = "password";
            string userName = "username";
            string expectedText = $"What's on your mind, {userName}?";
            Login.InputEmail(userEmail);
            Login.InputPassword(userPassword);
            Login.ClickLogin();
            Login.CheckThatWhatsOnYourMindElementExists(expectedText);
        }
    }
}
