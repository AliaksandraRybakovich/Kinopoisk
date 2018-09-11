Feature: CheckLoginToKinopoisk
	In order to use Kinopoisk
	As a user
	I want to log in throw Google account

 Background: 
    Given I go to the LogInPage on Kinopoisk	
	When  I click on the LogIn button
	Given I have not all badges on social panel
	When I click on button more
	Given I have logIn to account throw google
	When I click on button google badges

@mytag
Scenario Outline: Successful log in to Kinopoisk
	Given I have the page with google log in
	When I enter <login> and <password> in google account
	Then i use Kinopoisk as a user

	Examples: 
	| login | password |
	| alexandra.testatest@gmail.com | AlexRybka.Test1 |
