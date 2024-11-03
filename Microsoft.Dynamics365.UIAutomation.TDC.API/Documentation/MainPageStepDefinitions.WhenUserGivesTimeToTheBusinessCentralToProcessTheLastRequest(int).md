### [Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions](Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions').[MainPageStepDefinitions](MainPageStepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions')

## MainPageStepDefinitions.WhenUserGivesTimeToTheBusinessCentralToProcessTheLastRequest(int) Method

Suspends the test execution for the specified amount of time. Required when D365 needs some time to process/display data.

```csharp
public void WhenUserGivesTimeToTheBusinessCentralToProcessTheLastRequest(int seconds);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.MainPageStepDefinitions.WhenUserGivesTimeToTheBusinessCentralToProcessTheLastRequest(int).seconds'></a>

`seconds` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

### Example
When user gives '1' second to the Business Central to process the last request  
When user gives '3' seconds to the Business Central to process the last request