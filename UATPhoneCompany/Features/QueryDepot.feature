Feature: QueryDepot
	System for checking the depot stocks of a particular item

Scenario: The hardware exists
	Given the hardware name is 'Intel Processor'
	And the item exists
	When I attempt to check the depot's stock for the item
	Then the depot should respond with a successful message


Scenario: The hardware does not exist
	Given the hardware name is 'fan'
	And the item does not exist
	When I attempt to check the depot's stock for the item
	Then the depot should respond with an unsuccessful message
