Feature: Skill
User wants to add Skills into Profile Details
Acceptance Criteria
User is able to add the Skills


 Scenario: 01 Test Add Skill sucessfully
		When User enter skill as "CPP" and level as "Beginner"
        When clicks on Add button in education tab
		Then skill should be added to your profile.

Scenario: 02 Test Updating Skill sucessfully
		Given Skill "CPP" is added
		When User updates Skill to "CPP" and level as "Expert"
		And  clicks on update button in education tab
		Then "CPP" added in the list of skills

 Scenario: 03 Test Delete skill sucessfully
		When  User select to delete skill "CPP" 
		Then  skill should be deleted from the list.