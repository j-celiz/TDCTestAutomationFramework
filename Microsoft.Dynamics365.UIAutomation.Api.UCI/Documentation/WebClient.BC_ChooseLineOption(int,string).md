### [Microsoft.Dynamics365.UIAutomation.Api.UCI](Microsoft.Dynamics365.UIAutomation.Api.UCI.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI').[WebClient](WebClient.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient')

## WebClient.BC_ChooseLineOption(int, string) Method

Chooses specified context menu option for the specified line number (without specifing table name).

```csharp
internal Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult<bool> BC_ChooseLineOption(int lineNumber, string optionName);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_ChooseLineOption(int,string).lineNumber'></a>

`lineNumber` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_ChooseLineOption(int,string).optionName'></a>

`optionName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')

### Example
BC_ChooseLineOption(1, “Delete Line”)