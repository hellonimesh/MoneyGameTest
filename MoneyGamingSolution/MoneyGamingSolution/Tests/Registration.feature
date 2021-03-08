Feature: Registration

	In order to verify the DOB error message is display
	As a QA
	I want to submit an incomplete registration form

@registration
Scenario Outline: Verify DOB error message on registration page
	Given I navigate to MoneyGaming site
	And I click on JoinNow
	And I enter the <title> <name> and <surname>
	And I accept the Terms and Conditions
	When I submit the details
	Then I verify the <errorMessage>

Examples:
| title | name    | surname | errorMessage           |
| Mrs   | Rushika | Soni    | This field is required |
	
