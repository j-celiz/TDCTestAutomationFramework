### [Microsoft.Dynamics365.UIAutomation.Api.UCI](Microsoft.Dynamics365.UIAutomation.Api.UCI.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI').[WebClient](WebClient.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient')

## WebClient.BC_SearchForPage(string, int) Method

Searches for the specified criteria in Search For Page

```csharp
internal Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult<bool> BC_SearchForPage(string criteria, int thinkTime=2000);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_SearchForPage(string,int).criteria'></a>

`criteria` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Search criteria.

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_SearchForPage(string,int).thinkTime'></a>

`thinkTime` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Used to simulate a wait time between human interactions. The Default is 2 seconds.

#### Returns
[Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')

### Example
xrmBrowser.GlobalSearch.BC_SearchForPage("Purchase Orders");