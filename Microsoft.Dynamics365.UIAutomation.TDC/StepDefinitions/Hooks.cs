using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using TechTalk.SpecFlow.Infrastructure;
using Microsoft.Dynamics365.UIAutomation.Api.UCI;
using System.Security;
using Microsoft.Dynamics365.UIAutomation.Browser;

namespace Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions
{
    /// <summary>
    /// Bindings for test cases setup, teardown, logging and reporting.
    /// </summary>
    [Binding]
    public class Hooks : BaseStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;

        public Hooks(ScenarioContext scenarioContext, ISpecFlowOutputHelper specFlowOutputHelper)
        {
            _scenarioContext = scenarioContext;
            _specFlowOutputHelper = specFlowOutputHelper;
        }

        /// <summary>
        /// Executed once, before the test run. Creates a log file.
        /// </summary>
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Log.CreateLogFile();
        }

        /// <summary>
        /// Executed before each Feature.
        /// </summary>
        /// <param name="featureContext"></param>
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Log.InfoSimplified($"FEATURE: '{featureContext.FeatureInfo.Title} {featureContext.FeatureInfo.Description}' started.");
        }

        /// <summary>
        /// Executed before each Scenario. Creates an instance of WebClient.
        /// </summary>
        [BeforeScenario]
        public void BeforeScenario()
        {
            Log.InfoSimplified($"SCENARIO: '{_scenarioContext.ScenarioInfo.Title}' started.");
            client = new WebClient(TestSettings.Options);
            XrmApp = new XrmApp(client);
        }

        /// <summary>
        /// Executed before each Step.
        /// </summary>
        [BeforeStep]
        public void BeforeStep()
        {
            Log.InfoSimplified($"{_scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString().ToUpperInvariant()} {_scenarioContext.StepContext.StepInfo.Text}");
        }

        /// <summary>
        /// Executed after every steps. Takes a screenshot if TakeScreenshotAfterEveryStep==true.
        /// </summary>
        [AfterStep]
        public void AfterStep()
        {
            if (TestSettings.TakeScreenshotAfterEveryStep)
            {
                string ScreenshotFullPath = XrmApp.TakeScreenshot(_scenarioContext.ScenarioInfo.Title);
                _specFlowOutputHelper.AddAttachment(ScreenshotFullPath);
            }
        }

        /// <summary>
        /// Executed after each Scenario. Takes a screenshot if Scenario failed or TakeScreenshotIfTestPassed==true. Disposes the XrmApp (browser).
        /// </summary>
        [AfterScenario]
        public void AfterScenario()
        {
            if (_scenarioContext.TestError != null || TestSettings.TakeScreenshotIfTestPassed)
            {
                string ScreenshotPath = XrmApp.TakeScreenshot(_scenarioContext.ScenarioInfo.Title);
                _specFlowOutputHelper.AddAttachment(ScreenshotPath);
            }

            if (_scenarioContext.TestError != null)
            {
                Log.InfoSimplified($"SCENARIO: '{_scenarioContext.ScenarioInfo.Title}' FAILED with  error: {_scenarioContext.TestError.Message}");
            }
            else
            {
                Log.InfoSimplified($"SCENARIO: '{_scenarioContext.ScenarioInfo.Title}' PASSED.");
            }
            XrmApp.ForcedDispose();
        }

        /// <summary>
        /// Executed after each Feature.
        /// </summary>
        /// <param name="featureContext"></param>
        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Log.InfoSimplified($"FEATURE: '{featureContext.FeatureInfo.Title} {featureContext.FeatureInfo.Description}' ended.");
        }

        /// <summary>
        /// Executed once, after the test run. Saves the log file and cleands after the XrmApp.
        /// </summary>
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Log.CloseLogFile();
            XrmApp.Kill();
        }
    }
}
