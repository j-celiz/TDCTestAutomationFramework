### [Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions](Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions').[EntityStepDefinitions](EntityStepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions')

## EntityStepDefinitions.ThenUserSeesTheRecordIs(string, string, string) Method

```csharp
public void ThenUserSeesTheRecordIs(string sectionName, string fieldName, string expectedFieldValue);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesTheRecordIs(string,string,string).sectionName'></a>

`sectionName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesTheRecordIs(string,string,string).fieldName'></a>

`fieldName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.EntityStepDefinitions.ThenUserSeesTheRecordIs(string,string,string).expectedFieldValue'></a>

`expectedFieldValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Example
Then user sees that in section 'General' field 'Status' has a value 'Pending Approval'  
Then user sees that 'Sales Credit Memo' in section 'Lines' field 'Total Excl. GST (NZD)' has a value '200.00'