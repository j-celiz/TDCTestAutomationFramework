using System;
using System.Security;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;

namespace Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions
{

    /// <summary>
    /// Step Definitions for logging in, signing out, reading messages and some useful steps.
    /// </summary>
    [Binding]
    public class MainPageStepDefinitions : BaseStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;

        private readonly SecureString? _userName = TestSettings.UserName;
        private readonly SecureString? _userPassword = TestSettings.UserPassword;
        private readonly SecureString? _userMfaSecretKey = TestSettings.UserMfaSecretKey;
        private readonly SecureString? _approverName = TestSettings.ApproverName;
        private readonly SecureString? _approverPassword = TestSettings.ApproverPassword;
        private readonly Uri _xrmUri = new Uri(TestSettings.CrmUrl);

        public MainPageStepDefinitions(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }

        /// <summary>
        /// Creates a browser instance and logs into the D365 using the user credentials from appsettings.json (or if run from GitHub Actions from GitHub secrets).
        /// </summary>
        /// <example>
        /// Given user is logged in
        /// When user logs in
        /// </example>
        [StepDefinition(@"user is logged in")]
        [StepDefinition(@"user logs in")]
        public void GivenUserIsLoggedIn()
        {            
            XrmApp = new XrmApp(client);
            XrmApp.OnlineLogin.Login(_xrmUri, _userName, _userPassword, _userMfaSecretKey);
        }

        /// <summary>
        /// Creates a browser instance and logs into the D365 using the approver credentials from appsettings.json (or if run from GitHub Actions from GitHub secrets).
        /// </summary>
        /// <example>
        /// Given approver is logged in
        /// When approver logs in
        /// </example>
        [StepDefinition(@"approver is logged in")]
        [StepDefinition(@"approver logs in")]
        public void GivenApproverIsLoggedIn()
        {
            XrmApp = new XrmApp(client);
            XrmApp.OnlineLogin.Login(_xrmUri, _approverName, _approverPassword, _userMfaSecretKey);
        }

        /// <summary>
        /// Signs out from the D365 and disposes the browser instance.
        /// </summary>
        /// <example>
        /// When user signs out
        /// When approver signs out
        /// </example>
        [StepDefinition(@"user signs out")]
        [StepDefinition(@"approver signs out")]
        public void WhenUserSignsOut()
        {
            XrmApp.BusinessCentral.SignOut(_xrmUri.ToString());
            // Browser disposal is mandatory if the basic authorization is used.
            XrmApp.ForcedDispose();
        }

        /// <summary>
        /// Suspends the test execution for 10 seconds. To be used only when developing the test scenario.
        /// </summary>
        /// <example>
        /// Then developer has time to see the result
        /// </example>
        [StepDefinition(@"developer has time to see the result")]
        public void ThenDeveloperHasTimeToSeeTheResult()
        {
            XrmApp.ThinkTime(10000);
        }

        /// <summary>
        /// Suspends the test execution for the specified amount of time. Required when D365 needs some time to process/display data.
        /// </summary>
        /// <example>
        /// When user gives '1' second to the Business Central to process the last request
        /// When user gives '3' seconds to the Business Central to process the last request
        /// </example>
        /// <param name="seconds"></param>
        [StepDefinition(@"user gives '([^']*)' second to the Business Central to process the last request")]
        [StepDefinition(@"user gives '([^']*)' seconds to the Business Central to process the last request")]
        public void WhenUserGivesTimeToTheBusinessCentralToProcessTheLastRequest(int seconds)
        {
            XrmApp.ThinkTime(seconds*1000);
        }

        /// <summary>
        /// Checks if a page error is displayed. Used for negative testing.
        /// </summary>
        /// <example>
        /// Then user sees a page error message
        /// </example>
        [Then(@"user sees a page error message")]
        public void ThenUserSeesAPageErrorMessage()
        {
            var PageErrorMessage = XrmApp.BusinessCentral.GetPageErrorMessage();
            PageErrorMessage.Should().MatchRegex("The page has .*? error.*");
        }

        /// <summary>
        /// Checks if the "Status must be equal to 'Open'" was displayed and closes the dialog message.
        /// </summary>
        /// <example>
        /// Then user sees an incorrect status information
        /// </example>
        [Then(@"user sees an incorrect status information")]
        public void ThenUserSeesAnIncorrectStatusInformation()
        {
            var DialogMessage = XrmApp.BusinessCentral.GetDialogMessage();
            DialogMessage.Should().Contain("Status must be equal to 'Open'");
            XrmApp.BusinessCentral.Dialog_ClickButton("OK");
        }

        /// <summary>
        /// Clicks the refresh link that appears together with the page error message. Used for negative testing.
        /// </summary>
        /// <example>
        /// When user refreshes the page
        /// </example>
        [When(@"user refreshes the page")]
        public void WhenUserRefreshesThePage()
        {
            XrmApp.BusinessCentral.ClickRefreshLink();
        }

        //============== <TEMPDEV for Assurity Cloud> ====================

        [Given(@"developer opens '([^']*)'")]
        public void GivenDeveloperOpens(string url)
        {
            XrmApp = new XrmApp(client);
            XrmApp.BusinessCentral.TEMP_OpenUrl(url);
        }

        [Given(@"developer opens the url from github secret")]
        public void DeveloperOpensUrl()
        {
            XrmApp = new XrmApp(client);
            XrmApp.BusinessCentral.TEMP_OpenUrl();
        }

        [When(@"developer searches for '([^']*)'")]
        public void WhenDeveloperSearchesFor(string searchValue)
        {
            XrmApp.BusinessCentral.TEMP_SearchFor(searchValue);
        }

        [Then(@"developer sees that search results are loaded")]
        public void ThenDeveloperSeesThatSearchResults()
        {
            string SearchSummary = XrmApp.BusinessCentral.TEMP_GetSearchSummary();
            SearchSummary.Should().Contain("About");
        }

        [StepDefinition(@"user verify Item '([^']*)' is in stock")]
        public void ThenUserVerifyItemIsInStock(string itemNumber)
        {
            string uriString = _xrmUri.ToString();
            var CurrentItemInventoryStock = _scenarioContext["CurrentItemInventoryStock"].ToString();
            XrmApp.BusinessCentral.VerifyItemInStock(itemNumber, uriString, CurrentItemInventoryStock);
        }

        [StepDefinition(@"user checks current Items stock for Item number '([^']*)'")]
        public void WhenUserCheckCurrentItemsStockForItemNumber(string itemNumber)
        {
            string uriString = _xrmUri.ToString();
            string text = XrmApp.BusinessCentral.VerifyItemCurrentStock(itemNumber, uriString);
            _scenarioContext.Add("CurrentItemInventoryStock", text);
        }



        //============== </TEMPDEV for Assurity Cloud> ====================
    }
}
