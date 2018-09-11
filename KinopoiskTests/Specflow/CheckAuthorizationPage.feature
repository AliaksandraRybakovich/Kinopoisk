Feature: CheckAuthorizationPage
	In order to use Kinopoisk
	As a user
	I want to see Authorization page

@mytag
Scenario: Successful switch-over to AuthorizationPage
	Given I go to the LogInPage on Kinopoisk	
	When  I click on the LogIn button
	Then I see Authorization page 
