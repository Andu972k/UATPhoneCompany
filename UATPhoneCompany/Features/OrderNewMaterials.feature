Feature: OrderNewMaterials
	System for ordering new materials to fill the depot

Scenario: Order a new material to the depot
	Given the hardware name is 'fan'
	And the requested amount is 20
	When I order the new material
	Then the depot should respond with a successful message
