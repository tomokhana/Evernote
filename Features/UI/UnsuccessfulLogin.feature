Feature: UnsuccessfulLogin
As an SDET
I want to test the unsuccessful login functionality
So that I can verify that the user can not login if it is not registered

@ui_web @negative @priority_high
Scenario: Verify that login is unsuccessful if user is not registered
	Given I set the browser as "chrome"
	And I have navigated to the URL "https://evernote.com/"
	When I click Login button
	Then I should be redirected to Login page
	When I enter my email as "umernaumangg@gmail.com"
	And I click Continue
	Then I should see the error message as "There is no account for the username or email you entered."
	And I close the browser