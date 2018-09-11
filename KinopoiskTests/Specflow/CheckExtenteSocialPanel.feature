Feature: CheckExtenteSocialPanel
	In order to choose google social net
	As a user
	I want to extente my social panel

	Background: 
	Given I go to the LogInPage on Kinopoisk	
	When  I click on the LogIn button

@mytag
Scenario: Successful open Extente Social Panel
	Given I have not all badges on social panel
	When I click on button more
	Then I see the other social badges
