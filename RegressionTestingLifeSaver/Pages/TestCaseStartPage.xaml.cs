using RegressionTestingLifeSaver.Models;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for TestCaseStartPage.xaml
    /// </summary>
    public partial class TestCaseStartPage : Page
    {
        private TestPlan _testPlan;
        private CurrentPosition _currPosition;

        public TestCaseStartPage(TestPlan testPlan, CurrentPosition currPosition)
        {
            InitializeComponent();

            this._testPlan = testPlan;
            this._currPosition = currPosition;
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            TestDetailPage testDetailPage = new TestDetailPage(_testPlan, _currPosition);
            this.NavigationService.Navigate(testDetailPage);
        }
    }
}
