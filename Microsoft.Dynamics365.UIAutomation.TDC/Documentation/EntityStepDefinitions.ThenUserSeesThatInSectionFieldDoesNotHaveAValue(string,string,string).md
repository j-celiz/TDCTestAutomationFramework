### [Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions](Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions').[EntityStepDefinitions](EntityStepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions')

## EntityStepDefinitions.ThenUserSeesThatInSectionFieldDoesNotHaveAValue(string, string, string) Method

```csharp
public void ThenUserSeesThatInSectionFieldDoesNotHaveAValue(string sectionName, string fieldName, string unwantedFieldValue);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesThatInSectionFieldDoesNotHaveAValue(string,string,string).sectionName'></a>

`sectionName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesThatInSectionFieldDoesNotHaveAValue(string,string,string).fieldName'></a>

`fieldName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesThatInSectionFieldDoesNotHaveAValue(string,string,string).unwantedFieldValue'></a>

`unwantedFieldValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Example
Then user sees that in section 'General' field 'Balance Last Statement' does not have a value '0.00'  
Then user sees that 'Sales Credit Memo' in section 'Lines' field 'Total Excl. GST (NZD)' does not have a value '0.00'