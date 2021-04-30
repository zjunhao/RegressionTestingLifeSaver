using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionTestingLifeSaver.Models
{
    /// <summary>
    /// Specific test. 
    /// e.g. Verify that pdf can be rendered correctly in viewer.
    /// </summary>
    public class Test
    {
        public string Criticality { get; set; }
        public string TestName { get; set; }
        public string TestSteps { get; set; }
        public string ExpectedResult { get; set; }
        public TestResultEnum TestResult { get; set; }
        public string Comment { get; set; }

    }

    public enum TestResultEnum
    {
        Pass,
        Fail,
        NA
    }

}
