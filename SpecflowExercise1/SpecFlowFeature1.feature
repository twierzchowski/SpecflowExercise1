Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


Scenario Template: Add two numbers outline
	Given I have entered <number> into the calculator
	And I have entered 88 into the calculator
	When I press add
	Then the result should be 120 on the screen

	@tag2
	Examples: 
	| number |
	| 77     |
	| 88     |

	@tag3 @ignore
	Scenarios: 
	| number |
	| 99     |
	| 11     |