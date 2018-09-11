Feature: CheckExtentedPage
	In order to use extente search from Kinopoisk
	As a guest
	I want to swich-over to Extented Search Page

@mytag
Scenario: Successful switch-over to ExtentedSearchPage
	Given I have Home Page Kinopoisk 
	When I click on betton extente search page
	Then the result I see Extente search from Kinopoisk
