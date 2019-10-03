Feature: SpecFlowFeature3
	In order to do factorial
	As a math idiot
	I want to be told the sum of two numbers

@Factorial
Scenario: Factorial one number
	Given I press factorial
	When I have entered "3" into the calculator
	Then the factorial result should be "6" 
