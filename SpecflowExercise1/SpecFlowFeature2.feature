Feature: SpecFlowFeature2
	In order to quickly find video
	As a youtuber
	I want all related videos

@web
Scenario: youtube should match title
	When I youtube for 'abc'
	Then I should see 'ABC News'

