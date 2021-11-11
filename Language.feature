Feature: Language
User wants to add Language into Profile Details
Acceptance Criteria
User is able to add the Language

Background:
Given I navigate to application and click SignIn
	And  I enter the login credentials and click login
		| Email					 | Password           |
        | rakeshcr48@gmail.com   | anusree			  |


Scenario Outline:01. Test Adding Language sucessfully
		When User entering <Language> and <Level> in Language tab and click Add button
		Then <Language> should be added in the list of languages
		 Examples: 
		 | Language		|Level	   |
		 | "English"	| "Basic"  |
	

Scenario Outline:02.  Test Updating Language sucessfully
		When User clicks on Edit button near <Language> 
		And Update <UpdatedLanguage> and <UpdatedLevel> and click update button
		Then <UpdatedLanguage> should be updated 
		  Examples: 
		 | Language		| UpdatedLanguage	| UpdatedLevel	|
		 | "English"	| Spanish			| Fluent		| 
	 
		 
Scenario Outline:03 Test remove Language sucessfully
		When When User selects to delete button near language <Language>
		Then <Language> should be deleted from the list of languages
		  Examples: 
		 | Language		|
		 | "Spanish"	| 

		
				 


