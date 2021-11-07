Feature: Language
User wants to add Language into Profile Details
Acceptance Criteria
User is able to add the Language


 Scenario: 01 Test Adding Language sucessfully
		When User enter language as "English" and  level as "Basic"
        And  clicks on Add button 
		Then  "English" should be added in the list of languages

 Scenario: 02 Test Updating Language sucessfully
		Given Language "English" is added
		When User updates language to "Spanish" and level as "Fluent"
		And  clicks on update button 
		Then  I should see "Spanish" added in the list of languages


 Scenario: 03 Test Delete Language sucessfully
		When  User select to delete language "Spanish" 
		Then  "Spanish" should be deleted from the list of languages



