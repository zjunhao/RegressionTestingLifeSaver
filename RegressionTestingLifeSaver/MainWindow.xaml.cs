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
            CurrentPosition currPosition = new CurrentPosition(0, 0);

            TestPlanStartPage testPlanStartPage = new TestPlanStartPage(testPlan, currPosition);
            //TestDetailPage testDetailPage = new TestDetailPage();
            //TestCaseStartPage testCaseStartPage = new TestCaseStartPage();
            //TestCaseEndPage testCaseEndPage = new TestCaseEndPage();

            mainFrame.NavigationService.Navigate(testPlanStartPage);
        }
    }
}
