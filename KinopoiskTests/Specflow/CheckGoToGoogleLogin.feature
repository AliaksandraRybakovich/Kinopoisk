Feature: CheckGoToGoogleLogin
	In order to log in throw google account
	As a user
	I want to see Google sing in

	Background: 
	Given I go to the LogInPage on Kinopoisk	
	When  I click on the LogIn button
	Given I have not all badges on social panel
	When I click on button more

@mytag
Scenario: Successful switch-over to GoogleSingIn
	Given I have logIn to account throw google
	When I click on button google badges
	Then I see a page with input field for google 
