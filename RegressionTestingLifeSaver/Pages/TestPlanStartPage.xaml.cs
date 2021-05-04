using RegressionTestingLifeSaver.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegressionTestingLifeSaver.Pages
{
    /// <summary>
    /// Interaction logic for TestPlanStartPage.xaml
    /// </summary>
    public partial class TestPlanStartPage : Page
    {

        private CurrentPosition _currPosition;

        /// <summary>
        /// Stores all info needed for a test plan.
        /// </summary>
        public TestPlan TestPlan { get; set; }

        /// <summary>
        /// All available client types for testing.
        /// </summary>
        public List<string> ClientTypes { get; }



        public TestPlanStartPage(TestPlan testPlan, CurrentPosition currPosition)
        {
            InitializeComponent();

            this._currPosition = currPosition;
            this.TestPlan = testPlan;
            this.ClientTypes = GetClientTypes();

            DataContext = this;
        }

        /// <summary>
        /// Get a list of all available client types
        /// </summary>
        private List<string> GetClientTypes()
        {
            List<string> clientTypes = new List<string>();

            clientTypes.Add("UnityClient");
            clientTypes.Add("ThickClientClassic");
            clientTypes.Add("ThickClientCoreBased");
            clientTypes.Add("InternetExplorer");
            clientTypes.Add("Firefox");
            clientTypes.Add("Chrome");
            clientTypes.Add("Safari");
            clientTypes.Add("Opera");
            clientTypes.Add("Edge");
            clientTypes.Add("Desktop");
            clientTypes.Add("OnbaseStudio");
            clientTypes.Add("Configuration");
            clientTypes.Add("IPhone");
            clientTypes.Add("IPad");
            clientTypes.Add("AndroidPhone");
            clientTypes.Add("AndroidTablet");
            clientTypes.Add("WindowsTablet");
            clientTypes.Add("MSOffice");
            clientTypes.Add("MSOutlook");

            return clientTypes;
        }

        private void StartTestButton_Click(object sender, RoutedEventArgs e)
        {
            TestCaseStartPage testCaseStartPage = new TestCaseStartPage(TestPlan, _currPosition);
            this.NavigationService.Navigate(testCaseStartPage);
        }

    }
}
