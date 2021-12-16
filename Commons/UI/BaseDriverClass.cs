using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using Evernote.StepDefinitions.UI;

namespace Evernote.Commons.UI
{
    public class BaseDriverClass
    {
        public IWebDriver driver = null;

        public void InitializeBrowser(string browsername)
        {
            if (browsername.ToLower() == "chrome")
                driver = new ChromeDriver();
            else if (browsername.ToLower() == "firefox")
                driver = new FirefoxDriver();
            else if (browsername.ToLower() == "ie")
                driver = new InternetExplorerDriver();

            driver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
