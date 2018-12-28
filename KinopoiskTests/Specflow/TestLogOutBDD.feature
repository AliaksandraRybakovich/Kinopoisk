Feature: TestLogOutBDD
	In order to to log out from user account
	As a registered user
	I want to be log out from account

	Background: 
	Given I follow to the log in form
	And I click on button *Have Account*
	And I click on button *Yandex social network*
	When I have entered alexandra.testatest and AlexRybka.Test1 on Yandex form

@mytag
Scenario: Successfully Log Out
	Given I follow to the Home Page as a registered user
	And I click on logo from account
	When I click on button *Exit*
	Then the result I see Log Page as a unregistered user
