using Common.Model;
using LocalCommon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CustomerService.BL;
using LocalCommon.BL;

namespace CustomerService.ViewModels
{
    public class SelectClientViewModel : ViewModelBase
    {
        private Action _acceptCallBack;
        private Action _cancelCallBack;
        private DelegateCommand _selectCommand = null;
        private DelegateCommand _cancelCommand = null;

        ClientInfoBL clientInfoBL =null;
        private int? _selectedClientIdNumber;
        private Client _selectedClient;
        private IList<int> _clientIdNumbers;

        public Client SelectedClient
        {
            get => _selectedClient;
            set
            {
                SetProperty(ref _selectedClient, value);
            }
        }
        public int? SelectedClientIdNumber
        {
            get => _selectedClientIdNumber;
            set
            {
                SetProperty(ref _selectedClientIdNumber, value);
                if (_selectedClientIdNumber != null)
                {
                    SelectedClient = clientInfoBL.GetClientByIdNumber((int)SelectedClientIdNumber);
                    _selectCommand.InvokeCanExecuteChanged();
                }
            }
        }
        public IList<int> ClientIdNumbers { get => _clientIdNumbers; }
        public Action AcceptCallBack { get => _acceptCallBack; set => _acceptCallBack = value; }
        public Action CancelCallBack { get => _cancelCallBack; set => _cancelCallBack = value; }
        public ICommand SelectCommand { get => _selectCommand; }
        public ICommand CancelCommand { get => _cancelCommand; }

        public SelectClientViewModel()
        {
            _selectCommand = new DelegateCommand(OnSelect, CanSelect);
            _cancelCommand = new DelegateCommand(OnCancel);

            clientInfoBL = new ClientInfoBL();

            ResetMessages();

            try { 
                _clientIdNumbers = clientInfoBL.GetClientIdNumbers();
            }
            catch (Exception ex)
            {
                SetErrorMessage(ex, "loading data");
                return;
            }
            SelectedClientIdNumber = null;
        }

        private void OnSelect(object parameter)
        {
            _acceptCallBack();
        }
        
        private void OnCancel(object parameter)
        {
            _cancelCallBack();
        }

        private bool CanSelect(object parameter)
        {
            return SelectedClientIdNumber != null;
        }
    }
}
