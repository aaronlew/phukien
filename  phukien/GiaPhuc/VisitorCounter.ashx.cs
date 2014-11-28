using System;
using System.Web;
using Google.GData.Analytics;
using phukienipadx.Core;

namespace GiaPhuc
{
    /// <summary>
    /// Summary description for VisitorCounter
    /// </summary>
    public class VisitorCounter : IHttpHandler
    {
        private const string Id = "ga:73058806";
        private const string Visit = "ga:visits";
        private const string FormatVisitor = "<p> Hôm nay: {0}</p><p> Hôm qua: {1}</p><p> Tháng này: {2}</p><p> Năm nay: {3}</p>";

        #region IHttpHandler Members

        public void ProcessRequest(HttpContext context)
        {
            var service = new AnalyticsService("DoogalAnalytics");
            service.setUserCredentials(Define.EmailUser, Define.Password);

            var today = GetVisit(service, Id, Visit, DateTime.Today, DateTime.Today);
            var yesterday = GetVisit(service, Id, Visit, DateTime.Today.AddDays(-1), DateTime.Today.AddDays(-1));
            var firstDateOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var lastDateOfMonth = firstDateOfMonth.AddMonths(1).AddDays(-1);
            var thisMonth = GetVisit(service, Id, Visit, firstDateOfMonth, lastDateOfMonth);
            var firstDateOfYear = new DateTime(DateTime.Today.Year, 1, 1);
            var lastDateOfYear = firstDateOfYear.AddYears(1).AddDays(-1);
            var thisYear = GetVisit(service, Id, Visit, firstDateOfYear, lastDateOfYear);

            context.Response.ContentType = "text/plain";
            context.Response.Write(string.Format(FormatVisitor, today, yesterday, thisMonth, thisYear));

        }

        public bool IsReusable
        {
            get { return false; }
        }

        #endregion

        private string GetVisit(AnalyticsService service, string id, string metric, DateTime startDate, DateTime endDate)
        {
            var pageViewQuery = new DataQuery("https://www.google.com/analytics/feeds/data")
                                    {
                                        Ids = id,
                                        Metrics = metric,
                                        GAStartDate = startDate.ToString("yyyy-MM-dd"),
                                        GAEndDate = endDate.ToString("yyyy-MM-dd")
                                    };
            if (service.Query(pageViewQuery).Entries.Count > 0)
            {
                var pvEntry = service.Query(pageViewQuery).Entries[0] as DataEntry;

                if (pvEntry != null) return pvEntry.Metrics[0].Value;
            }

            return "1";
        }
    }
}