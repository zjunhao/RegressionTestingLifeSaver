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
        TestPlanViewModel testPlanViewModel;

        TestPlanStartPage testPlanStartPage;
        TestCaseStartPage testCaseStartPage;
        TestDetailPage testDetailPage;
        TestCaseEndPage testCaseEndPage;
        TestPlanEndPage testPlanEndPage;

        public MainWindow()
        {
            InitializeComponent();

            TestPlan testPlan = MockDataSourceService.populateTestPlan(1993);
            
            this.testPlanViewModel = new TestPlanViewModel(testPlan, PageIndex.TestPlanStart, 0, 0);
            this.testPlanViewModel.MoveNextClicked += MoveNextHandler;

            this.testPlanStartPage = new TestPlanStartPage(this.testPlanViewModel);
            this.testCaseStartPage = new TestCaseStartPage(this.testPlanViewModel);
            this.testDetailPage = new TestDetailPage(this.testPlanViewModel);
            this.testCaseEndPage = new TestCaseEndPage(this.testPlanViewModel);
            this.testPlanEndPage = new TestPlanEndPage(this.testPlanViewModel);


            mainFrame.NavigationService.Navigate(this.testPlanStartPage);
        }

        private void MoveNextHandler()
        {
            if (testPlanViewModel.CurrentPageIndex == PageIndex.TestDetail)
            {
                mainFrame.NavigationService.Navigate(this.testDetailPage);
            }
            else if (testPlanViewModel.CurrentPageIndex == PageIndex.TestCaseStart)
            {
                mainFrame.NavigationService.Navigate(this.testCaseStartPage);
            }
            else if (testPlanViewModel.CurrentPageIndex == PageIndex.TestCaseEnd)
            {
                mainFrame.NavigationService.Navigate(this.testCaseEndPage);
            }
            else if (testPlanViewModel.CurrentPageIndex == PageIndex.TestPlanEnd)
            {
                mainFrame.NavigationService.Navigate(this.testPlanEndPage);
            }
            else if (testPlanViewModel.CurrentPageIndex == PageIndex.TestPlanStart)
            {
                mainFrame.NavigationService.Navigate(this.testPlanStartPage);
            }
        }
    }
}
