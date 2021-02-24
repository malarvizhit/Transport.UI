Feature: Trip Request -	A trip request can be executed and results returned

@transport @trip @P1
Scenario Outline: Validate a trip can be displayed in the transport search page
	Given I launch Transport NSW Trip page
	And I enter "from" <fromlocation> in the trip planner module
	And I enter "to" <tolocation> in the trip planner module
	Then I should see the valid trip details displayed in the table
	Examples:
	| fromlocation                       | tolocation                         |
	| North Sydney Station, North Sydney | Town Hall Station, Sydney          |
	