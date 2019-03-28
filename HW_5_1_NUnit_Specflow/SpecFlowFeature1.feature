Feature: SpecFlowFeature1
	Go to page QA Automation Tools Tutorial
	Title page equals QA Automation Tools Tutorial

@mytag
Scenario: Title equals QA Automation Tools Tutorial
	Given I navigate to main page
	When I move to 'DEMO SITES'
	And click 'Automation Practice Switch Windows'
	Then the title opened page equals 'QA Automation Tools Tutorial'
