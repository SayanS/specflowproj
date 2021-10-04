Feature: Login
Test the login functionality of application
Will verify if the username and password are working as expected

@RegressionTest
@Browser:Chrome
Scenario Outline: Verify if the login functionality is working
	Given I have navigated to my application
	When I fill login form with '<username>' and '<password>'
	And I click login button
	Then EA page should be opened with URL'http://www.executeautomation.com/demosite/index.html'
    Then EA page should has title 'Execute Automation Selenium Test Site' 

	Examples:
		| username | password |
		| admin    | admin    |
		| karthik  | karthik  |