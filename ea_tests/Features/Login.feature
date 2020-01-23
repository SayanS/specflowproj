Feature: Login
Test the login functionality of application
Will verify if the username and password are working as expected

@RegressionTest
@Browser:Chrome
Scenario Outline: Verify if the login functionality is working
	Given I have navigated to my application
	When I fill login form with '<username>' and '<password>'
	And I click login button
	Then Current URL should be "sss"
	Then The title of EA page should be "Execute Automation Selenium Test Site" 

	Examples:
		| username | password |
		| admin    | admin    |
		| karthik  | karthik  |