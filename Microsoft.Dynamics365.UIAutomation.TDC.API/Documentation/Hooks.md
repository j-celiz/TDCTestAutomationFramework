### [Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions](Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions')

## Hooks Class

Bindings for test cases setup, teardown, logging and reporting.

```csharp
public class Hooks : Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.BaseStepDefinitions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [BaseStepDefinitions](BaseStepDefinitions.md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.BaseStepDefinitions') &#129106; Hooks

| Methods | |
| :--- | :--- |
| [AfterFeature(FeatureContext)](Hooks.AfterFeature(FeatureContext).md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.Hooks.AfterFeature(TechTalk.SpecFlow.FeatureContext)') | Executed after each Feature. |
| [AfterScenario()](Hooks.AfterScenario().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.Hooks.AfterScenario()') | Executed after each Scenario. Takes a screenshot if Scenario failed or TakeScreenshotIfTestPassed==true. Disposes the XrmApp (browser). |
| [AfterStep()](Hooks.AfterStep().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.Hooks.AfterStep()') | Executed after every steps. Takes a screenshot if TakeScreenshotAfterEveryStep==true. |
| [AfterTestRun()](Hooks.AfterTestRun().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.Hooks.AfterTestRun()') | Executed once, after the test run. Saves the log file and cleands after the XrmApp. |
| [BeforeFeature(FeatureContext)](Hooks.BeforeFeature(FeatureContext).md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.Hooks.BeforeFeature(TechTalk.SpecFlow.FeatureContext)') | Executed before each Feature. |
| [BeforeScenario()](Hooks.BeforeScenario().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.Hooks.BeforeScenario()') | Executed before each Scenario. Creates an instance of WebClient. |
| [BeforeStep()](Hooks.BeforeStep().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.Hooks.BeforeStep()') | Executed before each Step. |
| [BeforeTestRun()](Hooks.BeforeTestRun().md 'Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions.Hooks.BeforeTestRun()') | Executed once, before the test run. Creates a log file. |
