﻿using Common.Model;
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

        public SelectClient() : this(null)
        {
        }

        public SelectClient(int? userId)
        {
            InitializeComponent();
            //set up view model to call back when client data is ready
            ((SelectClientViewModel)DataContext).AcceptCallBack = OnAccept;
            ((SelectClientViewModel)DataContext).CancelCallBack = OnCancel;
            this.userId = userId;
        }

        private void OnAccept()
        {
            //navigate to LineInformation with client data that we got from the view model
            int? selectedClientIdNumber = ((SelectClientViewModel)DataContext).SelectedClientIdNumber;
            NavigationService.Navigate(new LineInformation(this.userId, selectedClientIdNumber));
        }
        private void OnCancel()
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}
