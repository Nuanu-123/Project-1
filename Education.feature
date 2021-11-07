Feature: Education
User wants to add education details into Profile Details
Acceptance Criteria
User is able to add the education details


Scenario: 01 Test Add Education sucessfully
	When User enter UniversityName as "Delhi University",CountryOfUniversity as "India",Title as "B.Tech", Degree as "Computer Science" and  YearOfGreaduation as "2012"  
	And  Clicks on Add button on Education page
	Then  New Education details should be added to the  profile.


 Scenario: 02 Test Delete Education sucessfully
		Given "B.Tech" is added to education 
		When  User selects to delete "B.Tech"
		Then  Education detail should be deleted from the list. 
