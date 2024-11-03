Feature: SmokeTest

@smoketest
Scenario: Sample test for google
	Given developer opens 'https://www.google.com/'
	When developer searches for 'Assurity Cloud'
	Then developer sees that search results are loaded
