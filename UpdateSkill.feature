Feature: Update Skill
check if update skill feature works

@mytag
Scenario: Edit Skills once added
	Given  I navigate to application
	And I click update and update skill and level
	Then I verify skill is successfully deleted
