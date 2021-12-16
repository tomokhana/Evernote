using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Evernote.PageObjectModels
{
    public class NotePage
    {
        readonly string note_title = "//textarea[@placeholder='Title']";
        readonly string user_profile = "//div[@data-tooltipmark='usernavitem']";
        readonly string logout_button = "//span[contains(text(), 'Sign out')]";
        readonly string note_button = "//span[@id='qa-NOTE_PARENT_NOTEBOOK_BTN']";
        readonly string note_iframe = "qa-COMMON_EDITOR_IFRAME";

        public IWebElement NoteButton(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(note_button));
        }

        public IWebElement NoteTitle(IWebDriver driver)
        {
            driver.SwitchTo().Frame(note_iframe);
            return driver.FindElement(By.XPath(note_title));
        }

        public IWebElement UserProfile(IWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();
            return driver.FindElement(By.XPath(user_profile));
        }

        public IWebElement Logout(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(logout_button));
        }
    }
}
