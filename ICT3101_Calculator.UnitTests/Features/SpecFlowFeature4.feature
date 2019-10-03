Feature: SpecFlowFeature4
	In order to calculate MTBF and Availability
	As a person who struggles with math
	I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
	Given I have a availability calculator
	When I have entered "5" and "6" into the calculator and press MTBF
	Then the result MTBF result should be "11"

@Availability
Scenario: Calculating Availability
	Given I have a availability calculator
	When I have entered "7" and "12" into the calculator and press Availability
	Then the result availability result should be "19"
