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
using Customer.ViewModels;
using Common.ModelToBlClient.Invoice;

namespace Customer.Views
{
    public partial class Receipt : Page
    {
        public Receipt() : this(null)
        {
        }
        //called by MainMenu's click event of Reciept button with
        //client id = MainMenu.loginDetails.userId
        public Receipt(int? clientId)
        {
            InitializeComponent();
            
            var dataContext = ((ReceiptViewModel)DataContext);
            if (dataContext != null)
            {
                //set the view model to return back with invoice data by calling our OnAccept()
                dataContext.AcceptCallBack = OnAccept;
                //set the client id of the view to be what we got from the constructor
                dataContext.ClientId = clientId;
            }
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
