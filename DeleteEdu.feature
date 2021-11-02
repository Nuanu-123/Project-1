Feature: Delete
check if delete feature works

@mytag
Scenario: Delete Education details once added
	
	Given I navigate to application
	And I delete the details of given education
	Then I verify education is successfully deleted