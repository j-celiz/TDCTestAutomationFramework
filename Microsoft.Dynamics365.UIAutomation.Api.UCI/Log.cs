using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.Dynamics365.UIAutomation.Api.UCI
{
    public class Log
    {
        private static TraceSource mySource;

        public static void CreateLogFile()
        {
            mySource = new TraceSource($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]");
            mySource.Switch = new SourceSwitch("sourceSwitch", "Error");
            mySource.Listeners.Remove("Default");
            TextWriterTraceListener textListener = new TextWriterTraceListener($"BusinessCentralAutomationLogFile.log");
            ConsoleTraceListener console = new ConsoleTraceListener(false);
            console.Filter = new EventTypeFilter(SourceLevels.Information);
            textListener.Filter = new EventTypeFilter(SourceLevels.Verbose);
            mySource.Listeners.Add(console);
            mySource.Listeners.Add(textListener);
            mySource.Switch.Level = SourceLevels.All;
        }

        public static void CloseLogFile()
        {
            mySource.Close();
        }

        public static void Verbose(string message,
                                    [CallerLineNumber] int lineNumber = 0,
                                    [CallerMemberName] string caller = null)
        {
            mySource.TraceEvent(TraceEventType.Verbose, lineNumber, $"{caller} : {message}");
            mySource.Flush();
        }

        public static void VerboseSimplified(string message)
        {
            mySource.TraceEvent(TraceEventType.Verbose, 0, $"{message}");
            mySource.Flush();
        }

        public static void Info(string message,
                                    [CallerLineNumber] int lineNumber = 0,
                                    [CallerMemberName] string caller = null)
        {
            mySource.TraceEvent(TraceEventType.Information, lineNumber, $"{caller} : {message}");
            mySource.Flush();
        }

        public static void InfoSimplified(string message)
        {
            mySource.TraceEvent(TraceEventType.Information, 0, $"{message}");
            mySource.Flush();
        }

        public static void Warning(string message,
                                    [CallerLineNumber] int lineNumber = 0,
                                    [CallerMemberName] string caller = null)
        {
            mySource.TraceEvent(TraceEventType.Warning, lineNumber, $"{caller} : {message}");
            mySource.Flush();
        }

        public static void Error(string message,
                                    [CallerLineNumber] int lineNumber = 0,
                                    [CallerMemberName] string caller = null)
        {
            mySource.TraceEvent(TraceEventType.Error, lineNumber, $"{caller} : {message}");
            mySource.Flush();
        }

        public static void Critical(string message,
                                        [CallerLineNumber] int lineNumber = 0,
                                        [CallerMemberName] string caller = null)
        {
            mySource.TraceEvent(TraceEventType.Critical, lineNumber, $"{caller} : {message}");
            mySource.Flush();
        }
    }
}