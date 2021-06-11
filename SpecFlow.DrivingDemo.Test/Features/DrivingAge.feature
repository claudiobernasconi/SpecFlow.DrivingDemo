Feature: DrivingAge
	Checks if a person is allowed to drive a car in a given country.

Scenario: Permitted driving in Switzerland
	Given The driver is 21 years old
	When they live in Switzerland 
	Then they are permitted to drive

Scenario: 16 years old can drive in the US
	Given The driver is 16 years old
	When they live in UnitedStates
	Then they are permitted to drive

Scenario: 16 years old cannot drive in Germany
	Given The driver is 16 years old
	When they live in Germany
	Then they are not permitted to drive