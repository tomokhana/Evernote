using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Evernote.PageObjectModels
{
    public class LoginPage
    {
        readonly string create_account = "//a[text()='Create account']";
        readonly string email_field = "//input[@id='username']";
        readonly string password_field = "//input[@id='password']";
        readonly string continue_button = "//input[@id='loginButton']";
        readonly string hidden_error_message = "//div[@id='responseMessage']";

        public IWebElement CreateButton(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(create_account));
        }

        public IWebElement EnterUsername(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(email_field));
        }

        public IWebElement EnterPassword(IWebDriver driver)
        {
            IWebElement element =  driver.FindElement(By.XPath(password_field));
            return element;
        }

        public IWebElement ContinueButton(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(continue_button));
        }

        public IWebElement ErrorMessage(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(hidden_error_message));
        }
    }
}
