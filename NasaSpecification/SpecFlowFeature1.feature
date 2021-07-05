Feature: API Key
	As a user of NASA open APIs I want to use the
   Astronomy Picture Of the Day apis, APOD, to get the
   APOD for a given date.

@mytag
Scenario Outline:  Generate API key,picture of the day
	Given i navigate to nasa homepage
	And input "<First Name>" input "<Last Name>" input "<EMail>"
	When i click on Signup button
	Then i am on api generation page
	
	
	Scenarios: 
	| First Name | Last Name | EMail              |
	| Testing    | tested    | firsttest@test.com |