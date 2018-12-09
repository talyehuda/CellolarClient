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
using Customer.ViewModels;

namespace Customer.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            ((LoginViewModel)DataContext).AcceptCallBack = OnAccept;
        }

        private bool OnAccept(Common.ModelToBlClient.Login loginDetails)
        {
            NavigationService.Navigate(new MainMenu(loginDetails));
            return true;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigating += NavigationService_Navigating;
        }

        private void NavigationService_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Forward)
                e.Cancel = true;
        }
    }
}
