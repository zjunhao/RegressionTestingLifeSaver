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
    /// Interaction logic for SectionEndPage.xaml
    /// </summary>
    public partial class TestCaseEndPage : Page
    {
        TestPlan _testPlan;

        public TestCaseEndPage(TestPlan testPlan)
        {
            InitializeComponent();

            this._testPlan = testPlan;
        }
    }
}
