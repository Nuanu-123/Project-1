Feature: Education
User wants to add education details into Profile Details
Acceptance Criteria
User is able to add the education details

Background:
Given I navigate to application and click SignIn
	And  I enter the login credentials and click login
		| Email					 | Password           |
        | rakeshcr48@gmail.com   | anusree			  |

Scenario Outline:01 Test Add Education sucessfully
	When User adds new education details  <University>,<Country>, <Title>,<Degree>,<GraduationYear>
	Then The  education detail with <Title> should be added to the Education page
	 Examples: 
		| University		| Country		 | Title    | Degree			  | GraduationYear   |
		| "Delhi University"		| "India"| "B.Tech" | "Computer Science" | "2018"		 | 

 Scenario Outline:02 Test delete education details sucessfully
		When When User selects to delete education with <Title>
		Then <Title> should be deleted from the list of education details
		  Examples: 
		 | Title		|
		 | "B.Tech"		| 
		 



