Feature: CheckExtentedSearch
	In order to search a current film
	As a guest
	I want to add a parameters for search a current film

	Background: 
	Given I have Home Page Kinopoisk 
	When I click on betton extente search page

@mytag
Scenario Outline: Successful search current film
	Given I use extente search on Kinopoisk
	When I add parameters <nameOfFilm> and <year>
	Then the result I found a current film with parameters <nameOfFilm> and <year>

	Examples: 
	| nameOfFilm | year |
	| Унесённые призраками | 2001 |
