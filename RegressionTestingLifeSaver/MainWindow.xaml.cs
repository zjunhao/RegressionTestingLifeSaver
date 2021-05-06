using RegressionTestingLifeSaver.Pages;
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
using RegressionTestingLifeSaver.Models;
using RegressionTestingLifeSaver.Services;
using RegressionTestingLifeSaver.ViewModels;

namespace RegressionTestingLifeSaver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TestPlan testPlan = MockDataSourceService.populateTestPlan(1993);
            TestPlanViewModel testPlanViewModel = new TestPlanViewModel(testPlan, PageIndex.TestPlanStart, 0, 0);

            TestPlanStartPage testPlanStartPage = new TestPlanStartPage(testPlanViewModel);
            TestCaseStartPage testCaseStartPage = new TestCaseStartPage(testPlanViewModel);
            TestDetailPage testDetailPage = new TestDetailPage(testPlanViewModel);
            TestCaseEndPage testCaseEndPage = new TestCaseEndPage(testPlanViewModel);
            TestPlanEndPage testPlanEndPage = new TestPlanEndPage(testPlanViewModel);

            mainFrame.NavigationService.Navigate(testCaseStartPage);
        }
    }
}
