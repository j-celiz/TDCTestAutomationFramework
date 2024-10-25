Feature: SmokeTest

@smoketest
Scenario: CL02 cloud test of chromedriver
	Given developer opens 'https://www.google.com/'
	When developer searches for 'Assurity Cloud'
	Then developer sees that search results are loaded
