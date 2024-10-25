### [Microsoft.Dynamics365.UIAutomation.Api.UCI](Microsoft.Dynamics365.UIAutomation.Api.UCI.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI').[WebClient](WebClient.md 'Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient')

## WebClient.BC_GetColumnIndexFromHeaders(ReadOnlyCollection<IWebElement>, string) Method

Private methods. Calculates the Column Index based on the header name.

```csharp
private Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult<int> BC_GetColumnIndexFromHeaders(System.Collections.ObjectModel.ReadOnlyCollection<OpenQA.Selenium.IWebElement> rowHeaders, string lineFieldName);
```
#### Parameters

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_GetColumnIndexFromHeaders(System.Collections.ObjectModel.ReadOnlyCollection_OpenQA.Selenium.IWebElement_,string).rowHeaders'></a>

`rowHeaders` [System.Collections.ObjectModel.ReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')[OpenQA.Selenium.IWebElement](https://docs.microsoft.com/en-us/dotnet/api/OpenQA.Selenium.IWebElement 'OpenQA.Selenium.IWebElement')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1 'System.Collections.ObjectModel.ReadOnlyCollection`1')

<a name='Microsoft.Dynamics365.UIAutomation.Api.UCI.WebClient.BC_GetColumnIndexFromHeaders(System.Collections.ObjectModel.ReadOnlyCollection_OpenQA.Selenium.IWebElement_,string).lineFieldName'></a>

`lineFieldName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult-1 'Microsoft.Dynamics365.UIAutomation.Browser.BrowserCommandResult`1')

#### Exceptions

[OpenQA.Selenium.NotFoundException](https://docs.microsoft.com/en-us/dotnet/api/OpenQA.Selenium.NotFoundException 'OpenQA.Selenium.NotFoundException')

[OpenQA.Selenium.NoSuchElementException](https://docs.microsoft.com/en-us/dotnet/api/OpenQA.Selenium.NoSuchElementException 'OpenQA.Selenium.NoSuchElementException')