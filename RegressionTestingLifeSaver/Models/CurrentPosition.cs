using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionTestingLifeSaver.Models
{
    /// <summary>
    /// Speicifies which test case and which test the user is currently at.
    /// </summary>
    public class CurrentPosition
    {
        public CurrentPosition()
        {
            throw new Exception("TestCaseIndex and TestIndex should be specified when creating CurrentPosition Class");
        }

        public CurrentPosition(int testCaseIndex, int testIndex)
        {
            this.TestCaseIndex = testCaseIndex;
            this.TestIndex = testIndex;
        }

        /// <summary>
        /// Test Case index in TestPlan.testCases list.
        /// -1 means in TestPlan Start page
        /// </summary>
        public int TestCaseIndex { get; set; }

        /// <summary>
        /// Test index in TestPlan.testCases[i].tests list.
        /// -1 means in Test Case Start page.
        /// -2 means in Test Case End page.
        /// </summary>
        public int TestIndex { get; set; }
    }
}
