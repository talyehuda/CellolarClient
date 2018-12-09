using LocalCommon.ViewModels;
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

namespace Customer.Views
{
    /// <summary>
    /// Interaction logic for OptimalPackage.xaml
    /// </summary>
    public partial class StatsAndRecommendation : Page
    {
        public StatsAndRecommendation():this(null)
        {
            
        }

        public StatsAndRecommendation(int? clientId)
        {
            InitializeComponent();
            //pass client id to the view model
            ((StatsAndRecommendationViewModel)DataContext).ClientId = clientId;
        }
    }
}
