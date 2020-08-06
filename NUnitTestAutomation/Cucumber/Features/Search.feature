Feature: Search
    User using google search
    
Scenario: User verifies last week's top search result for if.lv
    Given User opens "http://www.google.com" page

    When User searches for "if.lv"
    And User applies last week time filter
    And User clicks on top result

    Then page with "https://web.if.lv" domain name is opened