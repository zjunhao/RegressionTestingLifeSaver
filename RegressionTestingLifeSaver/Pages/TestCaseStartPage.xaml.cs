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
        public TestPlan TestPlan { get; set; }

        public TestCaseStartPage(TestPlan testPlan)
        {
            InitializeComponent();

            DataContext = this;

            this.TestPlan = testPlan;

            testCaseTextBlock.Text = TestPlan.TestCases[1].CaseName;

        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            TestDetailPage testDetailPage = new TestDetailPage(TestPlan);
            this.NavigationService.Navigate(testDetailPage);
        }
    }
}
