### [Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions](Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions')

## MainPageStepDefinitions Class

Step Definitions for logging in, signing out, reading messages and some useful steps.

```csharp
public class MainPageStepDefinitions : Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.BaseStepDefinitions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseStepDefinitions](BaseStepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.BaseStepDefinitions') &#129106; MainPageStepDefinitions

| Methods | |
| :--- | :--- |
| [GivenApproverIsLoggedIn()](MainPageStepDefinitions.GivenApproverIsLoggedIn().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.GivenApproverIsLoggedIn()') | Creates a browser instance and logs into the D365 using the approver credentials from appsettings.json (or if run from GitHub Actions from GitHub secrets). |
| [GivenUserIsLoggedIn()](MainPageStepDefinitions.GivenUserIsLoggedIn().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.GivenUserIsLoggedIn()') | Creates a browser instance and logs into the D365 using the user credentials from appsettings.json (or if run from GitHub Actions from GitHub secrets). |
| [ThenDeveloperHasTimeToSeeTheResult()](MainPageStepDefinitions.ThenDeveloperHasTimeToSeeTheResult().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.ThenDeveloperHasTimeToSeeTheResult()') | Suspends the test execution for 10 seconds. To be used only when developing the test scenario. |
| [ThenUserSeesAnIncorrectStatusInformation()](MainPageStepDefinitions.ThenUserSeesAnIncorrectStatusInformation().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.ThenUserSeesAnIncorrectStatusInformation()') | Checks if the "Status must be equal to 'Open'" was displayed and closes the dialog message. |
| [ThenUserSeesAPageErrorMessage()](MainPageStepDefinitions.ThenUserSeesAPageErrorMessage().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.ThenUserSeesAPageErrorMessage()') | Checks if a page error is displayed. Used for negative testing. |
| [WhenUserGivesTimeToTheBusinessCentralToProcessTheLastRequest(int)](MainPageStepDefinitions.WhenUserGivesTimeToTheBusinessCentralToProcessTheLastRequest(int).md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.WhenUserGivesTimeToTheBusinessCentralToProcessTheLastRequest(int)') | Suspends the test execution for the specified amount of time. Required when D365 needs some time to process/display data. |
| [WhenUserRefreshesThePage()](MainPageStepDefinitions.WhenUserRefreshesThePage().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.WhenUserRefreshesThePage()') | Clicks the refresh link that appears together with the page error message. Used for negative testing. |
| [WhenUserSignsOut()](MainPageStepDefinitions.WhenUserSignsOut().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.WhenUserSignsOut()') | Signs out from the D365 and disposes the browser instance. |
