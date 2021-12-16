using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Evernote.PageObjectModels
{
    public class LogoutPage
    {
        readonly string logout_message = "//h1[text()='You have logged out of Evernote.']";
        public IWebElement LogoutMessage(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(logout_message));
        }
    }
}
