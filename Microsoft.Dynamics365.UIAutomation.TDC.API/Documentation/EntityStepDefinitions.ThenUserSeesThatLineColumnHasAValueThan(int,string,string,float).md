### [Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions](Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions').[EntityStepDefinitions](EntityStepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions')

## EntityStepDefinitions.ThenUserSeesThatLineColumnHasAValueThan(int, string, string, float) Method

Checks if ActualLineFieldValue is greater/less than the expected value

```csharp
public void ThenUserSeesThatLineColumnHasAValueThan(int lineNumber, string columnName, string operationType, float expectedLineFieldValue);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesThatLineColumnHasAValueThan(int,string,string,float).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesThatLineColumnHasAValueThan(int,string,string,float).columnName'></a>

`columnName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesThatLineColumnHasAValueThan(int,string,string,float).operationType'></a>

`operationType` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesThatLineColumnHasAValueThan(int,string,string,float).expectedLineFieldValue'></a>

`expectedLineFieldValue` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

### Example
Then user sees that 'Purchase Order' line '2' column 'Direct Unit Cost Excl. GST' has a value greater than '0.00'