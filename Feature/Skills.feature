Feature: Skill
User wants to add Skills into Profile Details
Acceptance Criteria
User is able to add the Skills

@mytag
 Scenario: 01 Test Add Skill sucessfully
		Given User enter skill as "CPP"
        And   select level as  "Beginner"
		When  clicks on Add  button 
		Then  skill should be added to your profile. The alert message, "CPP has been added to your skills" will be displayed.

@mytag
 Scenario: 02 Test Update skill sucessfully
		Given User updates skill as "CPP"  
		And   updates level as  "Expert"
		When  clicks on Update  button 
		Then  skill should be updated. The alert message, "CPP has been updated to your skills" will be displayed.

@mytag
 Scenario: 03 Test Delete skill sucessfully
		When  User select to delete language  "CPP" 
		Then  skill should be deleted. The alert message, "CPP has been deleted" will be displayed.