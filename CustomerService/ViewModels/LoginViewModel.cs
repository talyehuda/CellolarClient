﻿using Common.Model;
using LocalCommon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LocalCommon.BL;
using Common.ModelToBlClient;

namespace CustomerService.ViewModels
{
    public class LoginViewModel:ViewModelBase
    {
        private Func<int,bool> _acceptCallBack;
        private DelegateCommand _loginCommand = null;
        public ICommand LoginCommand { get => _loginCommand; }
        //runs when user presses 'log in'
        //_acceptCallBack is called on login details of entered user
        public Func<int, bool> AcceptCallBack { get => _acceptCallBack; set => _acceptCallBack = value; }

        private int? _loginID = null;
        private string _loginContactNumber = null;
        private LoginBL loginBL;

        //contact id
        public int? LoginID
        {
            get => _loginID;
            set
            {
                SetProperty(ref _loginID, value);
                _loginCommand.InvokeCanExecuteChanged();
            }
        }

        //contact #
        public string LoginContactNumber
        {
            get => _loginContactNumber;
            set
            {
                SetProperty(ref _loginContactNumber, value);
            }
        }

        public LoginViewModel()
        {
            loginBL = new LoginBL();

            _loginCommand = new DelegateCommand(OnLogin);
        }



        private bool CheckFields()
        {
            ResetMessages();
            bool ret = false;
            string STR_REQ_FIELD = "Required field: ";
            if (_loginID == null)
                ErrorMessage = STR_REQ_FIELD + "id";
            else if (_loginContactNumber == null)
                ErrorMessage = STR_REQ_FIELD + "contact #";
            else
                ret = true;
            return ret;
        }

        private void OnLogin(object parameter)
        {
            if (CheckFields()) {
                ResetMessages();
                Login loginParams=null;
                try
                {
                    //log in...
                    loginParams = loginBL.LoginAsEmployee((int)_loginID, _loginContactNumber);

                    //return login details
                    _acceptCallBack(loginParams.UserId);
                }
                catch (Exception ex)
                {
                    SetErrorMessage(ex, "logging in");
                }
               
            }
        }
    }
}
