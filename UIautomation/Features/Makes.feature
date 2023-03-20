Feature: Makes
	I can browse Make pages

@smoke
Scenario: I can browse Make pages and go back to home
	Given I launch buggy rating website
	When I go to the make page
	And I go back to homepage from the Make page
	Then I assert the homepage has successful loaded