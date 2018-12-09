
using Common.Model;
using LocalCommon.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using CustomerService.BL;
using LocalCommon.BL;

namespace CustomerService.ViewModels
{
    public class ClientInformationViewModel : ViewModelBase
    {
        private ClientInfoBL clientInfoBL = null;


        private readonly DelegateCommand _clearCommand;
        private readonly DelegateCommand _deleteCommand;
        private readonly DelegateCommand _saveCommand;
        
        private IList<int> _clientsIdNumbers;
        private int? _selectedClientIdNumber;
        private Client _currentClient;
        private IList<ClientType> _clientTypes;
        private ClientType _clientTypeOfCurrentClient;
        

        public ClientInformationViewModel()
        {
            clientInfoBL = new ClientInfoBL();


            _clearCommand = new DelegateCommand(OnClear);
            _deleteCommand = new DelegateCommand(OnDelete, CanDelete);
            _saveCommand = new DelegateCommand(OnSave, CanSave);


            ResetMessages();
            try
            {
                _clientTypes = clientInfoBL.GetClientTypes();
                if (_clientTypes==null)
                    _clientTypes=new List<ClientType>(); 
            }
            catch (Exception ex)
            {
                
                SetErrorMessage(ex, "loading client types");
                return;
                
            }

            try
            {
                _clientsIdNumbers = ListToObservableCollection(clientInfoBL.GetClientIdNumbers());
                if (_clientsIdNumbers==null)
                    _clientsIdNumbers = new ObservableCollection<int>();
            }
            catch (Exception ex)
            {
                SetErrorMessage(ex, "loading client id numbers");
                return;
            }
            
            SelectedClientIdNumber = null;

        }

        public ICommand ClearCommand { get => _clearCommand; }
        public ICommand DeleteCommand { get => _deleteCommand; }
        public ICommand SaveCommand { get => _saveCommand; }

        public IList<int> ClientsIdNumbers
        {
            get => _clientsIdNumbers;
        }
        public Client CurrentClient
        {
            get => _currentClient;
            set
            {
                SetProperty(ref _currentClient, value);
                ClientTypeOfCurrentClient = _currentClient != null ? _clientTypes.FirstOrDefault((ClientType clientType) => (clientType.Id == _currentClient.ClientTypeId)) : null;

                _deleteCommand.InvokeCanExecuteChanged();
                _saveCommand.InvokeCanExecuteChanged();
            }
        }
        public int? SelectedClientIdNumber
        {
            get => _selectedClientIdNumber;
            set
            {
                SetProperty(ref _selectedClientIdNumber, value);

                ResetMessages();
                
                if (_selectedClientIdNumber != null)
                {
                    try
                    {
                        CurrentClient = clientInfoBL.GetClientByIdNumber((int)_selectedClientIdNumber);
                    }
                    catch (Exception ex)
                    {
                        SetErrorMessage(ex, "loading client data");
                        CurrentClient = new Client();
                    }
                    
                }
                else
                {
                    CurrentClient = new Client();
                }

                _deleteCommand.InvokeCanExecuteChanged();
                _saveCommand.InvokeCanExecuteChanged();

            }
        }
        public ClientType ClientTypeOfCurrentClient
        {
            get => _clientTypeOfCurrentClient;
            set
            {
                
                SetProperty(ref _clientTypeOfCurrentClient, value);

                ResetMessages();

                if (_currentClient != null && _clientTypeOfCurrentClient != null)
                {
                    _currentClient.ClientTypeId = _clientTypeOfCurrentClient.Id;
                }
            }
        }
        public IList<ClientType> ClientTypes
        {
            get => _clientTypes;
        }

        private bool checkFields()
        {
            bool ret = false;
            ResetMessages();
            const string STR_REQIRED_FIELD = "Required field ";

            if (isEmptyField(CurrentClient.Name))
                ErrorMessage = STR_REQIRED_FIELD + "Name";
            else if (isEmptyField(CurrentClient.LastName))
                ErrorMessage = STR_REQIRED_FIELD + "Last Name";
            else if (isEmptyField(CurrentClient.Address))
                ErrorMessage = STR_REQIRED_FIELD + "Address";
            else if (isEmptyField(ClientTypeOfCurrentClient))
                ErrorMessage = STR_REQIRED_FIELD + "Type";
            else if (isEmptyField(CurrentClient.ContactNameber))
                ErrorMessage = STR_REQIRED_FIELD + "Contact Number";
            else
                ret = true;

            return ret;
        }

        private bool CanSave(object parameter)
        {
            if (_currentClient == null)
                return false;
            else
            {
                return true;
            }
        }
        private void OnSave(object parameter)
        {

            ResetMessages();

            if (_clientsIdNumbers.Contains(_currentClient.ClientIdNumber))
            {
                //perform update operation
                if (checkFields())
                {
                    try
                    {
                        clientInfoBL.EditClient(_currentClient);
                        SelectedClientIdNumber = _currentClient.ClientIdNumber;
                        InfoMessage = "Client updated";
                    }

                    catch (Exception ex)
                    {
                        SetErrorMessage(ex, "editing client");
                    }
                }
            }
            else
            {
                //perform insert operation

                if (checkFields())
                {
                    try
                    {
                        clientInfoBL.AddClient(_currentClient);
                        _clientsIdNumbers.Add(_currentClient.ClientIdNumber);
                        SelectedClientIdNumber = _currentClient.ClientIdNumber;
                        InfoMessage = "Client added";
                    }

                    catch (Exception ex)
                    {
                        SetErrorMessage(ex, "adding client");
                    }
                }
                
            }
        }

        private bool CanDelete(object parameter)
        {
            return _selectedClientIdNumber != null;
        }
        private void OnDelete(object parameter)
        {
            ResetMessages();
            try
            {
                clientInfoBL.DeleteClient(CurrentClient);
                _clientsIdNumbers.Remove((int)_selectedClientIdNumber);
                SelectedClientIdNumber=null;
                InfoMessage = "Client deleted";
            }
            catch (Exception ex)
            {
                SetErrorMessage(ex,"deleting client");
            }
        }
        private void OnClear(object parameter)
        {
            ResetMessages();
            SelectedClientIdNumber = null;
        }



    }
}
