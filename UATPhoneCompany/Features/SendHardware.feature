Feature: SendHardware
	System for sending hardware from the depot to a given location

Scenario: The Hardware is in stock
	Given the hardware name is 'Intel Processor'
	And the requested amount is 20
	And the destination is 'Copenhagen'
	And the depot storage quantity is greater than the requested amount
	When I request the transfer of hardware
	Then the depot should respond with a successful message

Scenario: The Hardware is not in stock
	Given the hardware name is 'Intel Processor'
	And the requested amount is 40
	And the destination is 'Copenhagen'
	And the depot storage quantity is less than the requested amount
	When I request the transfer of hardware
	Then the depot should respond with an unsuccessful message