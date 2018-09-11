Feature: CheckLogOut
	In order to log out from your account
	As a user
	I want to log out from Kinopoisk

	Background: 
	Given I go to the LogInPage on Kinopoisk	
	When  I click on the LogIn button
	Given I have not all badges on social panel
	When I click on button more
	Given I have logIn to account throw google
	When I click on button google badges
	Given I have the page with google log in
	When I enter alexandra.testatest@gmail.com and AlexRybka.Test1 in google account

@mytag
Scenario: Successful log out
	Given I use Kinopoisk as a user
	When I click on log out button
	Then i use Kinopoisk as a guest

