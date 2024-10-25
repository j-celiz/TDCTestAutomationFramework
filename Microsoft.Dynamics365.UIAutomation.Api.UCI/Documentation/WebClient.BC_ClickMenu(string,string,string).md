### [Microsoft.Dynamics365.UIAutomation.Api.UCI](Microsoft.Dynamics365.UIAutomation.Api.UCI.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI').[WebClient](WebClient.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient')

## WebClient.BC_ClickMenu(string, string, string) Method

Clicks the specified menu button, then the specified child menu button, then the next specified child menu button

```csharp
internal Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult<bool> BC_ClickMenu(string menuTitle, string submenuTitle, string subSubmenuTitle);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_ClickMenu(string,string,string).menuTitle'></a>

`menuTitle` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_ClickMenu(string,string,string).submenuTitle'></a>

`submenuTitle` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_ClickMenu(string,string,string).subSubmenuTitle'></a>

`subSubmenuTitle` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')

#### Exceptions

[OpenQA.Selenium.NoSuchElementException](https://docs.microsoft.com/en-us/dotnet/api/OpenQA.Selenium.NoSuchElementException 'OpenQA.Selenium.NoSuchElementException')