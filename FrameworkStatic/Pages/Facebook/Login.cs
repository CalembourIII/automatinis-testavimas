using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.Facebook
{
    public class Login
    {
        public static void Open()
        {
            string url = "https://www.facebook.com/";
            Driver.OpenPage(url);
        }
        public static void CloseCookies()
        {
            Common.ClickElement("//*[@data-testid='cookie-policy-manage-dialog-accept-button']");
        }

        public static void InputEmail(string v)
        {
            Common.SendKeysToElement("//*[@id='email']", v);
        }

        public static void InputPassword(string v)
        {
            Common.SendKeysToElement("//*[@id='pass']", v);
        }
        public static void ClickLogin()
        {
            Common.ClickElement("//*[@data-testid='royal_login_button']");
        }

        public static void CheckThatWhatsOnYourMindElementExists(string whatsOnYourMindText)
        {
            Common.WaitForElementWithText(whatsOnYourMindText);
        }

    }
}
