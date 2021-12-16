Feature: SuccessfulLogin
As an SDET
I want to test the successful login functionality
So that I can verify that the user can login if it is registered

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
	And I close the browser