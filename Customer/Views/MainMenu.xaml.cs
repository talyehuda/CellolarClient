using Customer.ViewModels;
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

namespace Customer.Views
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// 
    /// code below allows for navigation between MainMenu and both Receipt and StatsAndRecommendation
    /// with passing information for relevant view models
    /// </summary>
    public partial class MainMenu : Page
    {
        //holds info about logged in user
        private Common.ModelToBlClient.Login loginDetails;

        public MainMenu():this(null)
        {
           
        }

        //called by Login.OnAccept() in order to pass login details to this constructor
        //OnAccept() is called by LoginViewModel.OnLogin()
        public MainMenu(Common.ModelToBlClient.Login loginDetails)
        {
            InitializeComponent();
            this.loginDetails = loginDetails;
            ((MainMenuViewModel)DataContext).LoginDetails = loginDetails;
        }


        private void btnReceipt_Click(object sender, RoutedEventArgs e)
        {
            //pass login details to Receipt view
            NavigationService.Navigate(new Receipt(this.loginDetails.UserId));
        }
        
        private void btnClientStats_Click(object sender, RoutedEventArgs e)
        {
            //pass login details to StatsAndRecommendation view
            NavigationService.Navigate(new StatsAndRecommendation(this.loginDetails.UserId));
        }
    }
}
