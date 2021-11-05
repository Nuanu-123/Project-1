Feature: Language
User wants to add Language into Profile Details
Acceptance Criteria
User is able to add the Language

@mytag
 Scenario: 01 Test Add Language sucessfully
		Given User enter language as "English"
        And   select level as "Basic"
		When  clicks on Add action button 
		Then  Language should be added to your profile. The alert message, "English has been added to your languages" will be displayed.

@mytag
 Scenario: 02 Test Update Language sucessfully
		Given User choose to update language "English"
		Then User updates language to "Spanish" 
		And   updates level as "Fluent"
		When  clicks on Update button 
		Then  Language should be updated. The alert message, "Spanish has been updated to your languages" will be displayed.

@mytag
 Scenario: 03 Test Delete Language sucessfully
		When  User select to delete language "Spanish" 
		Then  Language should be deleted. The alert message, "Spanish has been deleted from your languages" will be displayed.