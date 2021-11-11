Feature: Skill
User wants to add Skills into Profile Details
Acceptance Criteria
User is able to add the Skills


Background:
Given I navigate to application and click SignIn
	And  I enter the login credentials and click login
		| Email					 | Password           |
        | rakeshcr48@gmail.com   | anusree			  |


Scenario Outline:01. Test Add Skill sucessfully
		When User enter <Skill> and <Level> in Skill tab and click Add button
		Then <Skill> should be added in the list of Skills
		 Examples: 
		 | Skill	|Level	      |
		 | "CPP"	| "Beginner"  |
	

Scenario Outline:02.  Test Update Skill sucessfully
		When User clicks on Edit near <Skill> 
		And Update <Skill> and <Level> and click update
		Then <Skill> should be updated for the <Level>
		  Examples: 
		 | Skill	|Level			   |
		 | "CPP"	| "Expert"		   |
		 
		 
Scenario Outline:03 Test delete Skill sucessfully
		When User clicks on remove btn near <Skill> 
		Then <Skill> should be deleted from the list
		  Examples: 
		 | Skill	|
		 | "CPP"	| 


