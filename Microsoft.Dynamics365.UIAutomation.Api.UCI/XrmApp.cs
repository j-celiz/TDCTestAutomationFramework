// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.Dynamics365.UIAutomation.Api.UCI
{
    public class XrmApp : IDisposable
    {
        internal WebClient _client;

        public List<ICommandResult> CommandResults => _client.CommandResults;

        public XrmApp(WebClient client)
        {
            _client = client;
        }

        public BusinessCentral BusinessCentral => this.GetElement<BusinessCentral>(_client);

        public OnlineLogin OnlineLogin => this.GetElement<OnlineLogin>(_client);
        public Navigation Navigation => this.GetElement<Navigation>(_client);
        public CommandBar CommandBar => this.GetElement<CommandBar>(_client);
        public Grid Grid => this.GetElement<Grid>(_client);
        public Entity Entity => this.GetElement<Entity>(_client);
        public Dialogs Dialogs => this.GetElement<Dialogs>(_client);
        public Timeline Timeline => this.GetElement<Timeline>(_client);
        public BusinessProcessFlow BusinessProcessFlow => this.GetElement<BusinessProcessFlow>(_client);
        public Dashboard Dashboard => this.GetElement<Dashboard>(_client);
        public RelatedGrid RelatedGrid => this.GetElement<RelatedGrid>(_client);

        public GlobalSearch GlobalSearch => this.GetElement<GlobalSearch>(_client);
		public QuickCreate QuickCreate => this.GetElement<QuickCreate>(_client);
        public Lookup Lookup => this.GetElement<Lookup>(_client);
        public Telemetry Telemetry => this.GetElement<Telemetry>(_client);

        public T GetElement<T>(WebClient client)
            where T : Element
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { client });
        }

        public void ThinkTime(int milliseconds)
        {
            _client.ThinkTime(milliseconds);
        }
        public void ThinkTime(TimeSpan timespan)
        {
            _client.ThinkTime((int)timespan.TotalMilliseconds);
        }

        public void Dispose()
        {
            _client?.Dispose();
        }

        public void ForcedDispose()
        {
            _client?.ForcedDispose();
        }

        public void Kill()
        {
            _client?.Kill();
        }

        public string TakeScreenshot(string screenshotTitle)
        {
            ScreenshotImageFormat FileFormat = ScreenshotImageFormat.Png;
            string StrFileName = $"Screenshot_{screenshotTitle.Replace(" ", "-")}_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss-fff")}.{FileFormat}";

            // ./screenshots/Screenshot_CL02-cloud-test-of-chromedriver_2022-10-12_01-20-59-915.Png

            string ScreenshotsDirectory = "./screenshots/";
            if (!Directory.Exists(ScreenshotsDirectory)) Directory.CreateDirectory(ScreenshotsDirectory);
            var ScreenshotPath = ScreenshotsDirectory + StrFileName;
            var driver = _client.Browser.Driver;
            ITakesScreenshot ScreenshotDriver = driver as ITakesScreenshot;
            if (ScreenshotDriver == null)
                throw new InvalidOperationException(
                    $"The driver type '{driver.GetType().FullName}' does not support taking screenshots.");
            var Screenshot = ScreenshotDriver.GetScreenshot();
            Screenshot.SaveAsFile(ScreenshotPath);
            if (!File.Exists(ScreenshotPath))
            {
                throw new FileNotFoundException($"Following file '{ScreenshotPath}' was not found");
            }
            else
            {
                Log.VerboseSimplified($"Screenshot taken: {ScreenshotPath}");
                return ScreenshotPath;
            }
        }
    }
}
