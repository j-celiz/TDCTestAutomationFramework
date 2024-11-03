using Microsoft.Dynamics365.UIAutomation.Api.UCI;

namespace Microsoft.Dynamics365.UIAutomation.TDC.StepDefinitions
{
    /// <summary>
    /// Base class for all Step Definitions classes. Creates an instance of WebClient.
    /// </summary>
    public class BaseStepDefinitions
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static WebClient client;
        public static XrmApp XrmApp;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
