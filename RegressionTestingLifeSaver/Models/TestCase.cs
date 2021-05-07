using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionTestingLifeSaver.Models
{
    /// <summary>
    /// Corresponds to Test Cases.
    /// e.g. Image Viewer / PDF Viewer / Viewer Permissions etc.
    /// </summary>
    public class TestCase 
    {
        public List<Test> Tests { get; set; }

        public string CaseName { get; set; }

        /// <summary>
        /// TimeTakenHours hrs and TimeTakenMinutes mins for total time taken for testing current test case.
        /// </summary>
        public int TimeTakenHours { get; set; }

        /// <summary>
        /// TimeTakenHours hrs and TimeTakenMinutes mins for total time taken for testing current test case.
        /// </summary>
        public int TimeTakenMinutes { get; set; }

        public string Note { get; set; }
    }
}
