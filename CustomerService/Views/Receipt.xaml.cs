using Common.Model;
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
      
using CustomerService.ViewModels;
using Common.ModelToBlClient.Invoice;

namespace CustomerService.Views
{
    /// <summary>
    /// Interaction logic for Receipt.xaml
    /// </summary>
    public partial class Receipt : Page
    {
        //called by MainMenu's click event of Reciept button with
        //client id = MainMenu.loginDetails.userId
        public Receipt()
        {
            InitializeComponent();

            //set the view model to return back with invoice data by calling our OnAccept()
            ((ReceiptViewModel)DataContext).AcceptCallBack = OnAccept;
        }
        
        private bool OnAccept(ClientInvoice clientInvoice)
        {
            //pass invoice data the the ReceiptResult to be passed later on by
            //ReceiptResult to ReceiptResultViewModel
            NavigationService.Navigate(new ReceiptResult(clientInvoice));

            return true;
        }
    }

 

}
