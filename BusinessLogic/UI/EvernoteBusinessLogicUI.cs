using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.Commons.UI;
using Evernote.PageObjectModels;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Evernote.BusinessLogic.UI
{
    public class EvernoteBusinessLogicUI : BaseDriverClass
    {
        readonly LandingPage obj_landingpage = new();
        readonly LoginPage obj_loginpage = new();
        readonly HomePage obj_homepage = new();
        readonly NotePage obj_notepage = new();
        readonly LogoutPage obj_logoutpage = new();
        public void InitializeBrowserAndMaximize(string browsername)
        {
            InitializeBrowser(browsername);
        }

        public void QuitBrowser()
        {
            CloseBrowser();
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(5000);
        }

        public void ClickLoginButton()
        {
            IWebElement element = obj_landingpage.LoginButton(driver);
            element.Click();
        }

        public void VerifyRedirectionToLoginPage()
        {
            IWebElement element = obj_loginpage.CreateButton(driver);
            Assert.IsTrue(element.Displayed);
        }

        public void TypeUserName(string username)
        {
            IWebElement element = obj_loginpage.EnterUsername(driver);
            element.SendKeys(username);
        }

        public void TypePassword(string password)
        {
            Thread.Sleep(2000);
            IWebElement element = obj_loginpage.EnterPassword(driver);
            element.SendKeys(password);
        }

        public void ClickContinueButton()
        {
            IWebElement element = obj_loginpage.ContinueButton(driver);
            element.Click();
            Thread.Sleep(5000);
        }

        public void VerifyErrorMessage(string errormessage)
        {
            IWebElement element = obj_loginpage.ErrorMessage(driver);
            Thread.Sleep(5000);
            Assert.AreEqual(errormessage, element.Text);
        }

        public void VerifyHomeIcon()
        {
            Thread.Sleep(20000);
            IWebElement element = obj_homepage.HomeIcon(driver);
            Assert.IsTrue(element.Displayed);
        }

        public void ClickCreateNewNote()
        {
            IWebElement element = obj_homepage.CreateNewNote(driver);
            element.Click();
        }

        public void VerifyNoteTitleVisibility()
        {
            Thread.Sleep(10000);
            IWebElement element = obj_notepage.NoteButton(driver);
            Assert.IsTrue(element.Displayed);
        }

        public void WriteANote(string notetext)
        {
            Actions action = new Actions(driver);
            IWebElement element = obj_notepage.NoteTitle(driver);
            action.MoveToElement(element).Click().SendKeys(notetext);
            action.SendKeys(Keys.Enter);
            action.Build().Perform();
            Thread.Sleep(5000);
        }

        public void ClickUserProfile()
        {
            IWebElement element = obj_notepage.UserProfile(driver);
            element.Click();
        }

        public void ClickLogout()
        {
            IWebElement element = obj_notepage.Logout(driver);
            element.Click();
        }

        public void VerifyLogoutMessage(string logoutmessage)
        {
            Thread.Sleep(15000);
            IWebElement element = obj_logoutpage.LogoutMessage(driver);
            Assert.AreEqual(logoutmessage, element.Text);
        }

        public void ClickLatestNote()
        {
            IWebElement element = obj_homepage.LatestNote(driver);
            element.Click();
        }
    }
}
