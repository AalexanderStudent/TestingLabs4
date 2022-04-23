Feature: Calculator

@testForMietLabs
Scenario: Add two numbers
	Given the first number is 120
	And the second number is 230
	When the two numbers are added
	Then the result should be 350

Scenario: Sub two numbers
	Given the first number is 350
	And the second number is 70
	When the two numbers are subtract
	Then the result should be 280

Scenario: Mult two numbers
	Given the first number is 45
	And the second number is 15
	When the two numbers are multiply
	Then the result should be 675

Scenario: Div two valid numbers
	Given the first number is 45
	And the second number is 15
	When the two numbers are divide
	Then the result should be 3


Scenario: Divide by zero
	Given the first number is 50
	And the second number is 0
	When the two numbers are divide
	Then should be thrown DiviedByZeroException