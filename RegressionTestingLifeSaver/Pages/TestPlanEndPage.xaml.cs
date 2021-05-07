using RegressionTestingLifeSaver.ViewModels;
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
    /// Interaction logic for TestPlanEndPage.xaml
    /// </summary>
    public partial class TestPlanEndPage : Page
    {
        public TestPlanViewModel testPlanViewModel;

        public TestPlanEndPage(TestPlanViewModel testPlanViewModel)
        {
            InitializeComponent();

            this.testPlanViewModel = testPlanViewModel;
            DataContext = this.testPlanViewModel;
        }

        private void MovePreviousButton_Click(object sender, RoutedEventArgs e)
        {
            testPlanViewModel.MovePrevious();
        }
    }
}
