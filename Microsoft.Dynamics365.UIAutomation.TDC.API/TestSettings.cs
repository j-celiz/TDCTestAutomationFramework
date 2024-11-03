// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
using Microsoft.Dynamics365.UIAutomation.Browser;
using Microsoft.Extensions.Configuration;
using System.Security;

namespace Microsoft.Dynamics365.UIAutomation.TDC
{
    public static class TestSettings
    {
        private static IConfigurationRoot MyConfig = new ConfigurationBuilder()
                                                            .AddJsonFile("appsettings.json")
                                                            .Build();

        public static SecureString? UserName => Environment.OSVersion.ToString().Contains("Unix")
                                                ? Environment.GetEnvironmentVariable("USER_NAME").ToSecureString()
                                                : MyConfig.GetValue<string>("AppSettings:UserName").ToSecureString();

        public static SecureString? UserPassword => Environment.OSVersion.ToString().Contains("Unix")
                                                    ? Environment.GetEnvironmentVariable("USER_PASSWORD").ToSecureString()
                                                    : MyConfig.GetValue<string>("AppSettings:UserPassword").ToSecureString();

        public static SecureString? UserMfaSecretKey => Environment.OSVersion.ToString().Contains("Unix")
                                                        ? Environment.GetEnvironmentVariable("USER_MFA_SECRET_KEY").ToSecureString()
                                                        : MyConfig.GetValue<string>("AppSettings:UserMfaSecretKey").ToSecureString();

        public static SecureString? ApproverName => Environment.OSVersion.ToString().Contains("Unix")
                                                    ? Environment.GetEnvironmentVariable("APPROVER_NAME").ToSecureString()
                                                    : MyConfig.GetValue<string>("AppSettings:ApproverName").ToSecureString();

        public static SecureString? ApproverPassword => Environment.OSVersion.ToString().Contains("Unix")
                                                        ? Environment.GetEnvironmentVariable("APPROVER_PASSWORD").ToSecureString()
                                                        : MyConfig.GetValue<string>("AppSettings:ApproverPassword").ToSecureString();

        public static SecureString? ApproverMfaSecretKey => Environment.OSVersion.ToString().Contains("Unix")
                                                        ? Environment.GetEnvironmentVariable("APPROVER_MFA_SECRET_KEY").ToSecureString()
                                                        : MyConfig.GetValue<string>("AppSettings:ApproverMfaSecretKey").ToSecureString();

        public static string? CrmUrl => Environment.OSVersion.ToString().Contains("Unix")
                                        ? Environment.GetEnvironmentVariable("CRM_URL")
                                        : MyConfig.GetValue<string>("AppSettings:CrmUrl");

        public static string? BcEmailRecipient => Environment.OSVersion.ToString().Contains("Unix")
                                                  ? Environment.GetEnvironmentVariable("BC_EMAIL_RECIPIENT")
                                                  : MyConfig.GetValue<string>("AppSettings:EmailRecipient");
        private static string? DriversPath => Environment.OSVersion.ToString().Contains("Unix")
                                      ? Environment.GetEnvironmentVariable("CHROMEDRIVER_PATH")
                                      : MyConfig.GetValue<string>("FrameworkSettings:DriversPath");

        public static bool TakeScreenshotIfTestPassed => Environment.OSVersion.ToString().Contains("Unix")
                                                          ? bool.Parse(Environment.GetEnvironmentVariable("BOOL_TAKE_SCREENSHOT_IF_PASSED"))
                                                          : MyConfig.GetValue<bool>("FrameworkSettings:TakeScreenshotIfTestPassed");

        public static bool TakeScreenshotAfterEveryStep => Environment.OSVersion.ToString().Contains("Unix")
                                                            ? bool.Parse(Environment.GetEnvironmentVariable("BOOL_TAKE_SCREENSHOT_AFTER_EVERY_STEP"))
                                                            : MyConfig.GetValue<bool>("FrameworkSettings:TakeScreenshotAfterEveryStep");

        private static bool UseHeadlessMode => Environment.OSVersion.ToString().Contains("Unix")
                                                ? bool.Parse(Environment.GetEnvironmentVariable("BOOL_USE_HEADLESS_MODE"))
                                                : MyConfig.GetValue<bool>("FrameworkSettings:UseHeadlessMode");

        private static readonly string Type = "Chrome";
        private static readonly string RemoteType = "Chrome";
        private static readonly string RemoteHubServerURL = "http://1.1.1.1:4444/wd/hub";

        // Once you change this instance will affect all follow tests executions
        public static BrowserOptions SharedOptions = new BrowserOptions
        {
            BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), Type),
            StartMaximized = true,
            PrivateMode = false,
            FireEvents = false,
            Headless = UseHeadlessMode,
            Kiosk = false,
            UserAgent = false,
            DefaultThinkTime = 2000,
            RemoteBrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), RemoteType),
            RemoteHubServer = new Uri(RemoteHubServerURL),
            UCITestMode = false,
            UCIPerformanceMode = false,
            DriversPath = Path.IsPathRooted(DriversPath) ? DriversPath : Path.Combine(Directory.GetCurrentDirectory(), DriversPath),
            DisableExtensions = false,
            DisableFeatures = false,
            DisablePopupBlocking = true,
            DisableSettingsWindow = false,
            EnableJavascript = true,
            NoSandbox = true,
            DisableGpu = true,
            DumpDom = false,
            EnableAutomation = true,
            DisableImplSidePainting = false,
            DisableDevShmUsage = true,
            DisableInfoBars = false,
            TestTypeBrowser = false
        };

        // Create a new options instance, copy of the share, to use just in the current test, modifications in test will not affect other tests
        public static BrowserOptions Options => new BrowserOptions 
        {
            BrowserType = SharedOptions.BrowserType,
            StartMaximized = true,
            PrivateMode = SharedOptions.PrivateMode,
            FireEvents = SharedOptions.FireEvents,
            Headless = SharedOptions.Headless,
            Kiosk = SharedOptions.Kiosk,
            UserAgent = SharedOptions.UserAgent,
            DefaultThinkTime = SharedOptions.DefaultThinkTime,
            RemoteBrowserType = SharedOptions.RemoteBrowserType,
            RemoteHubServer = SharedOptions.RemoteHubServer,
            UCITestMode = SharedOptions.UCITestMode,
            UCIPerformanceMode = SharedOptions.UCIPerformanceMode,
            DriversPath = SharedOptions.DriversPath,
            DisableExtensions = SharedOptions.DisableExtensions,
            DisableFeatures = SharedOptions.DisableFeatures,
            DisablePopupBlocking = SharedOptions.DisablePopupBlocking,
            DisableSettingsWindow = SharedOptions.DisableSettingsWindow,
            EnableJavascript = SharedOptions.EnableJavascript,
            NoSandbox = SharedOptions.NoSandbox,
            DisableGpu = SharedOptions.DisableGpu,
            DumpDom = SharedOptions.DumpDom,
            EnableAutomation = SharedOptions.EnableAutomation,
            DisableImplSidePainting = SharedOptions.DisableImplSidePainting,
            DisableDevShmUsage = SharedOptions.DisableDevShmUsage,
            DisableInfoBars = SharedOptions.DisableInfoBars,
            TestTypeBrowser = SharedOptions.TestTypeBrowser
        };

        public static string GetRandomString(int minLen, int maxLen)
        {
            char[] Alphabet = ("ABCDEFGHIJKLMNOPQRSTUVWXYZabcefghijklmnopqrstuvwxyz0123456789").ToCharArray();
            Random m_randomInstance = new Random();
            Object m_randLock = new object();

            int alphabetLength = Alphabet.Length;
            int stringLength;
            lock (m_randLock) { stringLength = m_randomInstance.Next(minLen, maxLen); }
            char[] str = new char[stringLength];

            // max length of the randomizer array is 5
            int randomizerLength = (stringLength > 5) ? 5 : stringLength;

            int[] rndInts = new int[randomizerLength];
            int[] rndIncrements = new int[randomizerLength];

            // Prepare a "randomizing" array
            for (int i = 0; i < randomizerLength; i++)
            {
                int rnd = m_randomInstance.Next(alphabetLength);
                rndInts[i] = rnd;
                rndIncrements[i] = rnd;
            }

            // Generate "random" string out of the alphabet used
            for (int i = 0; i < stringLength; i++)
            {
                int indexRnd = i % randomizerLength;
                int indexAlphabet = rndInts[indexRnd] % alphabetLength;
                str[i] = Alphabet[indexAlphabet];

                // Each rndInt "cycles" characters from the array, 
                // so we have more or less random string as a result
                rndInts[indexRnd] += rndIncrements[indexRnd];
            }
            return (new string(str));
        }
    }

    public static class UCIAppName
    {
        public const string Sales = "Sales Hub";
        public const string CustomerService = "Customer Service Hub";
        public const string Project = "Project Resource Hub";
        public const string FieldService = "Field Resource Hub";
    }
}
