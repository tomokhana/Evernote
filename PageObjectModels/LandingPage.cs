using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Evernote.PageObjectModels
{
    public class LandingPage
    {
        readonly string login_button = "//div[@class='row']//nav[@class='utility-nav']//a[text()='Log In']";
        public IWebElement LoginButton(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(login_button));
        }
    }
}
