Feature: API SmokeTest

@smoketest
Scenario Outline: Successfully retrieve category details by ID
	Given the API endpoint for category details "<endpoint>" is available
    #When I send a GET request to the endpoint with catalogue parameter "<catalogue>"
    #Then the response status code should be 200
    #And the response content type should be "application/json"
    #And the category name should be "<expectedCategoryName>"
    #And the category ID should be "<expectedCategoryId>"

Examples:
	| endpoint                                                                    | catalogue | expectedCategoryName | expectedCategoryId |
	| https://api.tmsandbox.co.nz/v1/Categories/6329/Details.json?catalogue=false | false     | Sample Category      | 6329               |
