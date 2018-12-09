using LocalCommon.BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.ViewModels
{
    /// <summary>
    /// an INotifyPropertyChanged object which allows for easy notification to 
    /// the view about the changed parameter
    /// </summary>

    //source: https://intellitect.com/getting-started-model-view-viewmodel-mvvm-pattern-using-windows-presentation-framework-wpf/
    public abstract class ViewModelBase : INotifyPropertyChanged
    {


        protected string _errorMessage;
        protected string _infoMessage;

        /// <summary>
        /// set's viewmodel's error message accourding to a given exception
        /// </summary>
        protected void SetErrorMessage(Exception e, string action)
        {
            ResetMessages();
            try
            {
                throw e;
            }
            catch (BLConnectionError)
            {
                ErrorMessage = "Connection error";
            }
            catch (BLServerError be)
            {
                string errMsg = "Error " + action;
                if (be.Message != null && be.Message.Length != 0)
                    errMsg += ": " + be.Message;

                ErrorMessage = errMsg;
            }
            catch (BLServerUnhandledError)
            {
                ErrorMessage = action + ": server error";
            }
            catch (System.Exception)
            {
                ErrorMessage = action + ": unexpected error occured";
            }
        }
        protected void ResetMessages()
        {
            ErrorMessage = null;
            InfoMessage = null;
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                SetProperty(ref _errorMessage, value);
            }
        }
        public string InfoMessage
        {
            get => _infoMessage;
            set
            {
                SetProperty(ref _infoMessage, value);
            }
        }

        /// <summary>
        /// sets property and notifies view model automatically
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName]string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }





        /// <summary>
        /// convert List object to ObservableCollection so that add/remove operations affect the view
        /// </summary>
        protected ObservableCollection<T> ListToObservableCollection<T>(List<T> list)
        {
            if (list == null)
                return null;

            ObservableCollection<T> collection = new ObservableCollection<T>();
            foreach (var item in list)
            {
                collection.Add(item);
            }
            return collection;
        }


        protected bool isEmptyField(object fieldValue)
        {
            if (fieldValue == null)
                return true;
            else
            {
                if (fieldValue.GetType() == typeof(string))
                {
                    return ((string)fieldValue) == "";
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
