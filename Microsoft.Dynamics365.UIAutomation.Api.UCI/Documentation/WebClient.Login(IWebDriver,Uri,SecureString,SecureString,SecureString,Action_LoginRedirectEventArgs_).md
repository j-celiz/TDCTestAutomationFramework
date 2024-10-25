### [Microsoft.Dynamics365.UIAutomation.Api.UCI](Microsoft.Dynamics365.UIAutomation.Api.UCI.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI').[WebClient](WebClient.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient')

## WebClient.Login(IWebDriver, Uri, SecureString, SecureString, SecureString, Action<LoginRedirectEventArgs>) Method

Logs into the D365. Supports both MFA and Basic Auth.

```csharp
private Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginResult Login(OpenQA.Selenium.IWebDriver driver, System.Uri uri, System.Security.SecureString username, System.Security.SecureString password, System.Security.SecureString mfaSecretKey=null, System.Action<Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs> redirectAction=null);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.Login(OpenQA.Selenium.IWebDriver,System.Uri,System.Security.SecureString,System.Security.SecureString,System.Security.SecureString,System.Action_Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs_).driver'></a>

`driver` [OpenQA.Selenium.IWebDriver](https://docs.microsoft.com/en-us/dotnet/api/OpenQA.Selenium.IWebDriver 'OpenQA.Selenium.IWebDriver')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.Login(OpenQA.Selenium.IWebDriver,System.Uri,System.Security.SecureString,System.Security.SecureString,System.Security.SecureString,System.Action_Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs_).uri'></a>

`uri` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.Login(OpenQA.Selenium.IWebDriver,System.Uri,System.Security.SecureString,System.Security.SecureString,System.Security.SecureString,System.Action_Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs_).username'></a>

`username` [System.Security.SecureString](https://docs.microsoft.com/en-us/dotnet/api/System.Security.SecureString 'System.Security.SecureString')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.Login(OpenQA.Selenium.IWebDriver,System.Uri,System.Security.SecureString,System.Security.SecureString,System.Security.SecureString,System.Action_Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs_).password'></a>

`password` [System.Security.SecureString](https://docs.microsoft.com/en-us/dotnet/api/System.Security.SecureString 'System.Security.SecureString')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.Login(OpenQA.Selenium.IWebDriver,System.Uri,System.Security.SecureString,System.Security.SecureString,System.Security.SecureString,System.Action_Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs_).mfaSecretKey'></a>

`mfaSecretKey` [System.Security.SecureString](https://docs.microsoft.com/en-us/dotnet/api/System.Security.SecureString 'System.Security.SecureString')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.Login(OpenQA.Selenium.IWebDriver,System.Uri,System.Security.SecureString,System.Security.SecureString,System.Security.SecureString,System.Action_Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs_).redirectAction'></a>

`redirectAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs 'Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginRedirectEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

#### Returns
[Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginResult 'Microsoft.Dynamics365.UIAutomation.Api.UCI.LoginResult')

#### Exceptions

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')