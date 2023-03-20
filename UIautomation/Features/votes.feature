Feature: User can vote for a car
	User can vote for a car 

Background:
	Given I launch buggy rating website
	And I register a new user and login


@vote @smoke
Scenario: User can vote for most popular car and vote count is increased
	Given I go to the popular model page
	When I vote the model without comment
	Then I verify vote successful
	And I verfiy vote count is increment

@vote
Scenario: User can vote for Mito
	Given I go to the overall page
	And I select the model "Mito" on overall page
	When I vote the model with comment
	Then I verify vote successful
	And I verify the Author and the comment is displayed in the table list

	