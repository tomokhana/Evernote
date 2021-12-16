using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Evernote.BusinessLogic.UI;
using Evernote.Commons.UI;

namespace Evernote.StepDefinitions.UI
{
    [Binding]
    internal class UIFeaturesSteps
    {
        readonly EvernoteBusinessLogicUI obj_ui = new();

        [Given(@"I set the browser as ""(.*)""")]
        public void GivenISetTheBrowserAs(string browsername)
        {
            obj_ui.InitializeBrowserAndMaximize(browsername);
        }

        [Given(@"I have navigated to the URL ""(.*)""")]
        public void IhavenavigatedtotheURL(string url)
        {
            obj_ui.Navigate(url);
        }

        [When(@"I click Login button")]
        public void IclickLoginbutton()
        {
            obj_ui.ClickLoginButton();
        }

        [Then(@"I should be redirected to Login page")]
        public void IShouldBeRedirectedToLoginPage()
        {
            obj_ui.VerifyRedirectionToLoginPage();
        }

        [When(@"I enter my email as ""(.*)""")]
        public void IEnterMyEmailAs(string email)
        {
            obj_ui.TypeUserName(email);
        }

        [When(@"I enter my password as ""(.*)""")]
        public void IEnterMyPasswordAs(string password)
        {
            obj_ui.TypePassword(password);
        }

        [When(@"I click Continue")]
        public void IClickContinue()
        {
            obj_ui.ClickContinueButton();
        }

        [When(@"I click the create new note")]
        public void IClickTheCreateNewNote()
        {
            obj_ui.ClickCreateNewNote();
        }

        [When(@"I write something in the note title as ""(.*)""")]
        public void IWriteSomethingInTheNoteTitleAs(string notetext)
        {
            obj_ui.WriteANote(notetext);
        }

        [When(@"I click logout")]
        public void IClickLogout()
        {
            obj_ui.ClickUserProfile();
            obj_ui.ClickLogout();
        }

        [When(@"I open the latest note created")]
        public void IOpenTheLatestNoteCreated()
        {
            obj_ui.ClickLatestNote();
        }

        [Then(@"I should see the error message as ""(.*)""")]
        public void IShouldSeeTheErrorMessageAs(string expectedvalue)
        {
            obj_ui.VerifyErrorMessage(expectedvalue);
        }

        [Then(@"I should see the Home Icon")]
        public void IShouldSeeTheHomeIcon()
        {
            obj_ui.VerifyHomeIcon();
        }

        [Then(@"I should see a blank title in the note page")]
        public void IShouldSeeABlankTitleInTheNotePage()
        {
            obj_ui.VerifyNoteTitleVisibility();
        }

        [Then(@"I should see the message on logout page as ""(.*)""")]
        public void IShouldSeeTheMessageOnLogoutPageAs(string logoutmessage)
        {
            obj_ui.VerifyLogoutMessage(logoutmessage);
        }

        [Then(@"I close the browser")]
        public void ICloseTheBrowser()
        {
            obj_ui.QuitBrowser();
        }
    }
}
