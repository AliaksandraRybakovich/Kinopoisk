Feature: CheckExtentedSearch
	In order to use extented search 
	As a guest
	I enter parameters and seach for those a film

	Background: Given I follow to the Home Page	as a guest
	And I click on button extented button search

@mytag
Scenario Outline: CheckExtentedSearch
	Given I input parameters <nameOfFilm> and <year>
	When I click on search button  
	Then I see the current film with parameter <nameOfFilm> and <year>

	Examples: 
	| nameOfFilm       | year |
	| Унесенные ветром | 2001 |
