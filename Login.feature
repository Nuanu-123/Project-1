
Feature: Login
Check if login functionality works

@mytag
Scenario Outline: Login to website 
	Given I navigate to application and click SignIn
	And  I enter the login credentials and click login
		| Email					 | Password           |
        | rakeshcr48@gmail.com   | anusree			  |

	