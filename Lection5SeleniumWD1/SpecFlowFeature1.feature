Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I navigate to <Name>Page
@MacBook
Scenario: Search elements contain search string
	Given I have entered 'Macbook' in search field
	When I press search button
	Then the results contain 'MacBook' in title
