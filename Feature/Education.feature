Feature: Education
User wants to add education details into Profile Details
Acceptance Criteria
User is able to add the education details

@mytag
 Scenario: 01 Test Add Education sucessfully
	Given User enter UniversityName as "Delhi University"
	And   Select CountryOfUniversity as "India"
	And   Select Title as "B.Tech"
	And   Enter Degree as "Computer Science"
	And   Select YearOfGreaduation as "2012"  
	When  Clicks on Add button on AddEducation page
	Then  Education should be added to the  profile. The Alert message "Education has been added" is displayed.


@mytag		
 Scenario: 02 Test Delete Education sucessfully
		When  User select to delete title "B.Tech" 
		Then  Education should be deleted. The alert message, "Education entry successfully removed" will be displayed.
