Feature: Application Login
	

@mytag
Scenario Outline: Succesful Login To Application
	Given I am in Application Home Page
	And I enter 'Username' and 'Password'
	When I click submit
	Then I see Application Home Page
	Then I LogOff
Examples: 
| Username     | Password |
| fox100596054 | Password04 |