Feature: WriteANote
As an SDET
I want to test the functionality of writing a note
So that I can verify that the note is successfullt written and saved

@ui_web @positive @priority_high
Scenario: Verify that login is successful if user is registered
	Given I set the browser as "chrome"
	And I have navigated to the URL "https://evernote.com/"
	When I click Login button
	Then I should be redirected to Login page
	When I enter my email as "umer.nauman1@gmail.com"
	And I click Continue
	And I enter my password as "Animal123@"
	And I click Continue
	Then I should see the Home Icon
	When I click the create new note
	Then I should see a blank title in the note page
	When I write something in the note title as "Evernote Automation"
	And I click logout
	Then I should see the message on logout page as "You have logged out of Evernote."
	And I close the browser