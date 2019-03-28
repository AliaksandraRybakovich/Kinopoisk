Feature: TestExtentedSearchBDD
	In order to search certain from portal 
	As a unregistered user
	I want to be use extented search from portal

@mytag
Scenario Outline: Successfully Extented Search
	Given I follow to Log Page as a unregistered user
	And I click on button *Extented Search*
	And I enter <nameOfFilm> and <yearFilm>
	And I click on button *Search*
	When I click on movie references
	Then the result should be certain film of search

	Examples: 
	| nameOfFilm | yearFilm |
	| Унесённые призраками | 2001 |
