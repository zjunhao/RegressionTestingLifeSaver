using RegressionTestingLifeSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegressionTestingLifeSaver.ViewModels
{
    // TODO: Add exception handler so that user does not lose data already input if excpetion occurs.
    public class TestPlanViewModel
    {
        #region Member Variables
        // ---------------- Test information -------------------
        public TestPlan TestPlan { get; set; }

        public TestCase CurrentTestCase { get; private set; }

        public Test CurrentTest { get; private set; }

        // ---------------- Test page indexes ------------------
        public PageIndex CurrentPageIndex;

        // Warning:
        // You must update CurrentTestCaseIndex before CurrentTestIndex;
        // If not, CurrentTestIndex and CurrentTest will point to a new test in previous TestCase rather than a new test in new TestCase
        /// <summary>
        /// Index of test case in TestPlan.TestCases list. Updating index will update CurrentTestCase automatically.
        /// </summary>
        private int _currentTestCaseIndex;
        public int CurrentTestCaseIndex
        {
            get { return _currentTestCaseIndex; }
            private set 
            {
                if (value >= TestPlan.TestCases.Count())
                    throw new ArgumentOutOfRangeException("index out of bound for TestPlan.TestCases");

                // TODO: if old and new value are the same don't update?
                _currentTestCaseIndex = value;
                CurrentTestCase = TestPlan.TestCases[value];
            }
        }

        /// <summary>
        /// Index of test in TestPlan.TestCases[].Tests list. Updating index will update CurrentTest automatically.
        /// </summary>
        private int _currentTestIndex;
        public int CurrentTestIndex
        {
            get { return _currentTestIndex; }
            private set 
            {
                if (value >= CurrentTestCase.Tests.Count)
                    throw new ArgumentOutOfRangeException("index out of bound for TestPlan.TestCases.Tests");

                _currentTestIndex = value;
                CurrentTest = CurrentTestCase.Tests[value];
            }
        }

        // ------------------------- events -------------------------------
        public delegate void MoveNextClickedDelegate();
        public event MoveNextClickedDelegate MoveNextClicked;

        #endregion

        #region Constructor
        public TestPlanViewModel(TestPlan testPlan, PageIndex pageIndex, int testCaseIndex, int testIndex)
        {
            if (testPlan == null) 
                throw new ArgumentNullException("testPlan cannot be null");
            if (testCaseIndex >= testPlan.TestCases.Count()) 
                throw new ArgumentOutOfRangeException("testCaseIndex larger than number of testCases in testPlan");
            if (testIndex >= testPlan.TestCases[testCaseIndex].Tests.Count()) 
                throw new ArgumentOutOfRangeException("testIndex larger than number of tests in testcase");

            this.TestPlan = testPlan;
            this.CurrentPageIndex = pageIndex;
            this.CurrentTestCaseIndex = testCaseIndex;
            this.CurrentTestIndex = testIndex;
        }
        #endregion

        #region Utility Methods
        public void MoveNext()
        {
            // TODO: Didn't consider scenario when test cases are empty, tests in test cases are empty, need adding logic to handle it, maybe already handled by OutOfRangeException check when setting index.

            if (CurrentPageIndex == PageIndex.TestPlanStart)            // Test Plan Start
            {
                CurrentPageIndex = PageIndex.TestCaseStart;
                CurrentTestCaseIndex = 0;
                CurrentTestIndex = 0;
            }
            else if (CurrentPageIndex == PageIndex.TestCaseStart)       // Test Case Start
            {
                CurrentPageIndex = PageIndex.TestDetail;
            }
            else if (CurrentPageIndex == PageIndex.TestDetail)          // Test
            {
                if (CurrentTestIndex < CurrentTestCase.Tests.Count() - 1) 
                {
                    // has next test in test case
                    CurrentTestIndex++;
                }
                else 
                {
                    // currently at last test inside test case.
                    CurrentPageIndex = PageIndex.TestCaseEnd;
                }
            }
            else if (CurrentPageIndex == PageIndex.TestCaseEnd)        // Test Case End
            {
                if (CurrentTestCaseIndex < TestPlan.TestCases.Count() - 1) 
                {
                    // has next test case to test
                    CurrentPageIndex = PageIndex.TestCaseStart;
                    CurrentTestCaseIndex++;
                    CurrentTestIndex = 0;
                }
                else 
                {
                    // currently at last test case inside test plan
                    CurrentPageIndex = PageIndex.TestPlanEnd;
                }
            }
            else if (CurrentPageIndex == PageIndex.TestPlanEnd)        // Test Plan End
            {
                // Next butto should be disabled.
            }

            // TODO: don't fire this event if moving next not succeed ??
            // Fire MoveNextClicked event
            if (MoveNextClicked != null)
            {
                MoveNextClicked();
            }
        }

        public void MovePrevious()
        {

        }



        #endregion

    }

    // Combines with currentTestCaseIndex and currentTestIndex to uniquely identify what exact page the user is at.
    public enum PageIndex
    {
        TestPlanStart,
        TestCaseStart, // TestPlan.TestCases[currentTestCaseIndex]
        TestDetail,    // TestPlan.TestCases[currentTestCaseIndex].Tests[currentTestIndex]
        TestCaseEnd,   // TestPlan.TestCases[currentTestCaseIndex]
        TestPlanEnd
    }
}
