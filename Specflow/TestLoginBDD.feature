Feature: TestLoginBDD
	In order to use the portal
	As a registered user
	I want to be log in account

@mytag
Scenario Outline: Successfully Log In
	Given I follow to the log in form
	And I click on button *Have Account*
	And I click on button *Yandex social network*
	When I have entered <login> and <password> on Yandex form
	Then I see Home Page as a registered user

	Examples: 
	| login | password |
	| alexandra.testatest | AlexRybka.Test1 |
