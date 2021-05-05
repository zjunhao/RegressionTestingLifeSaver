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

        public int TimeTaken { get; set; }

        public string Note { get; set; }
    }
}
