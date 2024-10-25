### [Microsoft.Dynamics365.UIAutomation.Api.UCI](Microsoft.Dynamics365.UIAutomation.Api.UCI.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI').[WebClient](WebClient.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient')

## WebClient.BC_CheckColumnsHaveSameValues(string, string, string) Method

Throws NoSuchElementException if specified line/row/record doesn't have the same value in provided two columns/fields.

```csharp
internal Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult<bool> BC_CheckColumnsHaveSameValues(string givenColumn, string columnToCheck, string line);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_CheckColumnsHaveSameValues(string,string,string).givenColumn'></a>

`givenColumn` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_CheckColumnsHaveSameValues(string,string,string).columnToCheck'></a>

`columnToCheck` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_CheckColumnsHaveSameValues(string,string,string).line'></a>

`line` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')

#### Exceptions

[OpenQA.Selenium.NoSuchElementException](https://docs.microsoft.com/en-us/dotnet/api/OpenQA.Selenium.NoSuchElementException 'OpenQA.Selenium.NoSuchElementException')