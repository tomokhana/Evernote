Feature: OpenANote
As an SDET
I want to test the functionality of opening a note
So that I can verify that the note is successfullt opened

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
	When I open the latest note created
	Then I should see a blank title in the note page
	And I close the browser