using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionTestingLifeSaver.Models
{
    /// <summary>
    /// Corresponds to test plan.
    /// e.g. Unity Client Viewer
    /// </summary>
    public class TestPlan
    {
        public List<TestCase> testCases { get; set; }

        public string PlanName { get; set; }
        public string Tester { get; set; }
        public string Database { get; set; }
        public string ClientType { get; set; }
        public string ClientVersion { get; set; }
        public string BuildNumber { get; set; }
    }

    public enum ClientTypeEnum
    {
        InternetExplorer,
        Firefox,
        Chrome,
        Safari,
        Opera,
        Edge,
        ThickClientClassic,
        ThickClientCoreBased,
        UnityClient,
        Desktop,
        OnbaseStudio,
        Configuration,
        IPhone,
        IPad,
        AndroidPhone,
        AndroidTablet,
        WindowsTablet,
        MSOffice,
        MSOutlook
    }
}
