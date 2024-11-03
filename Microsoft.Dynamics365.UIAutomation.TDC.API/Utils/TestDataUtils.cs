using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;

namespace Microsoft.Dynamics365.UIAutomation.TDC.Utils
{
    public class TestDataUtils
    {
        public static string ProcessTestData(string data)
        {
            string FinalData = data;
            var DataGenerator = new Dictionary<string, Func<string>>
            {
                ["{CurrentMonthAndYear}"] = () => DateTime.Now.ToString("MMMM yyyy"),
                ["{CurrentDate}"] = () => DateTime.Now.ToString("MMMM dd, yyyy"),
                ["{FirstDayOfCurrentMonth}"] = () => DateTime.Now.ToString("01/MM/yyyy"),
                ["{FirstDayOfNextMonth}"] = () => DateTime.Now.AddMonths(1).Date.ToString("01/MM/yyyy"),
                ["{LastDayOfCurrentMonth}"] = () => (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1)).ToString("dd/MM/yyyy"),
                ["{LastDayOfFutureSixMonths}"] = () => (new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(7).AddDays(-1)).ToString("dd/MM/yyyy"),
                ["{TimeStamp}"] = () => DateTime.Now.ToString("ddMMyyHHmmss"),
                ["{DateStamp}"] = () => DateTime.Now.ToString("ddMMyyH"),
                ["{DateToday}"] = () => DateTime.Now.ToString("d/MM/yyyy")
            };

            foreach (Match match in Regex.Matches(data, @"\{\w*\}"))
            {
                string MatchValue = match.Value;
                if (DataGenerator.ContainsKey(MatchValue))
                {
                    string GeneratedData = DataGenerator[MatchValue]();
                    FinalData = FinalData.Replace(MatchValue, GeneratedData);
                }
                else
                {
                    throw new Exception($"{MatchValue} is not defined");
                }
            }
            return FinalData;
        }

        public static string ProcessExpectedData(string data)
        {
            Match match = Regex.Match(data, @"\{([^}]*)\}");
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return data;
        }
    }
}