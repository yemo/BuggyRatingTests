Feature: User
	As a User,
	I should register and login to the website

@smoke
Scenario: Cancel register a new user
	Given I launch buggy rating website
	When I go to the register page
	And I enter random user details on the register page
	And I click Cancel on the register page

@smoke
Scenario: Display warning message for invalid login
	Given I launch buggy rating website
	When I enter the invalid username and password
	Then I assert the warning message is "Invalid username/password"


@smoke
Scenario: User can login
	Given I launch buggy rating website
	When I enter the username "x0test" and the password "Asdfghjkl1234!"
	Then I assert the greeting message is "Hi, x"