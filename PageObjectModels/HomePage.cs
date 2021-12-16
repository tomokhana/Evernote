using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Evernote.PageObjectModels
{
    public class HomePage
    {
        readonly string home_icon = "//button[@id='qa-NAV_HOME']";
        readonly string create_note = "//div[@id='qa-HOME_WIDGET_CONTROL_Notes_2|0_0|0_3MCQT3|13']";
        readonly string latest_note = "//article[@data-asloc='Notes']//div[@id='qa-HOME_NOTE_WIDGET_NOTE_LIST_2|0_0|0_3MCQT3|13']//article[1]//span";
        public IWebElement HomeIcon(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(home_icon));
        }

        public IWebElement CreateNewNote(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(create_note));
        }

        public IWebElement LatestNote(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(latest_note));
        }
    }
}
