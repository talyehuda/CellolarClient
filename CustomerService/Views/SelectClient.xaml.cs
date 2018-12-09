using Common.Model;
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
using CustomerService.ViewModels;

namespace CustomerService.Views
{
    /// <summary>
    /// Interaction logic for SelectClient.xaml
    /// </summary>
    public partial class SelectClient : Page
    {
        private int? userId;

        public int? SelectedClientIdNumber
        {
            get => ((SelectClientViewModel)DataContext).SelectedClientIdNumber;
        }
        
        public SelectClient() : this(null)
        {
        }

        public SelectClient(int? userId)
        {
            InitializeComponent();
            ((SelectClientViewModel)DataContext).AcceptCallBack = OnAccept;
            ((SelectClientViewModel)DataContext).CancelCallBack = OnCancel;
            this.userId = userId;
        }

        private void OnAccept()
        {
            NavigationService.Navigate(new LineInformation(this.userId, SelectedClientIdNumber));
        }
        private void OnCancel()
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
