using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CustomerService.Views
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        private int? userId;

        public MainMenu():this(null)
        {
           
        }

        public MainMenu(int? userId)
        {
            InitializeComponent();
            this.userId = userId;

        }


        private void btnClientInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientInformation());
        }

        private void btnReceipt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Receipt());
        }

        private void btnLineInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SelectClient(this.userId));
        }

        private void btnSimulator_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Simulator());
        }

        private void btnClientStats_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientStatsAndRecommendation());
        }
    }
}
