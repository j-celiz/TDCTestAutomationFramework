### [Microsoft.Dynamics365.UIAutomation.Api.UCI](Microsoft.Dynamics365.UIAutomation.Api.UCI.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI').[WebClient](WebClient.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient')

## WebClient.BC_SetLineField(int, string, string) Method

Enters specified value in the specified field inside specified line number.

```csharp
internal Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult<bool> BC_SetLineField(int lineNumber, string lineFieldName, string lineFieldValue);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_SetLineField(int,string,string).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_SetLineField(int,string,string).lineFieldName'></a>

`lineFieldName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_SetLineField(int,string,string).lineFieldValue'></a>

`lineFieldValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')

#### Exceptions

[OpenQA.Selenium.NoSuchElementException](https://docs.microsoft.com/en-us/dotnet/api/OpenQA.Selenium.NoSuchElementException 'OpenQA.Selenium.NoSuchElementException')