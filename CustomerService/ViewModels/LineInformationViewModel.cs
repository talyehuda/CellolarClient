
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
    public class LineInformationViewModel : ViewModelBase
    {
        
        private LineInfoBL lineInfoBL = null;
        private ClientInfoBL clientInfoBL = null;
        private readonly DelegateCommand _clearCommand;
        private readonly DelegateCommand _deleteCommand;
        private readonly DelegateCommand _saveCommand;
        private readonly DelegateCommand _calcTotalFixedPriceCommand;

        public ICommand SaveCommand { get => _saveCommand; }
        public ICommand DeleteCommand { get => _deleteCommand; }
        public ICommand ClearCommand { get => _clearCommand; }
        public ICommand CalcTotalFixedPriceCommand { get => _calcTotalFixedPriceCommand; }

        private int? _userId;

        private int? _clientId;
        private int? _clientIdNumber;
        
        private string _clientAsString;//the displayed client name
        private IList<Line> _lines;
        private Line _selectedLine = null;

        private List<Package> _packages;
        private Package _selectedPackage = null;

        private Package _currentPackage = null;
        private bool _currentPackageXminYpriceChecked;
        private int? _currentPackageMinutes;
        private double? _currentPackagePrice;
        private bool _currentPackageFamilyDiscountChecked;
        private bool _currentPackageFriendsChecked;
        private SelectedNumbers _currentPackageFriendNumbers;
        private string _currentPackageFriendNumber1;
        private string _currentPackageFriendNumber2;
        private string _currentPackageFriendNumber3;
        private double? _currentPackageDiscountPercentage;
        private bool _currentPackageFavouriteNumberChecked;
        private double? _currentPackageTotalFixedPrice;
        private string _selectedLineNumber;

        ///<summary>marks when it's needed to add new SelectedNumbers</summary>
        private bool selectedNumbersChanged=false;
        private bool lineChanged = false;

        public LineInformationViewModel()
        {

            lineInfoBL = new LineInfoBL();
            clientInfoBL = new ClientInfoBL();

            //set up commands for buttons
            _clearCommand = new DelegateCommand(OnClear);
            _deleteCommand = new DelegateCommand(OnDelete, CanDelete);
            _saveCommand = new DelegateCommand(OnSave, CanSave);
            _calcTotalFixedPriceCommand = new DelegateCommand(OnCalcTotalFixedPrice, CanCalcTotalFixedPrice);

            ResetMessages();
            try
            {
                Packages = lineInfoBL.GetPackages();
            }
            catch (Exception ex)
            {
                SetErrorMessage(ex, "loading data");
                return;
            }

            if (Packages == null)
                Packages = new List<Package>();
            SelectedPackage = null;

        }

        private bool CanCalcTotalFixedPrice(object parameter)
        {
            return SelectedPackage != null;
        }

        private void OnCalcTotalFixedPrice(object parameter)
        {
            ResetMessages();
            try
            {
                CurrentPackageTotalFixedPrice= lineInfoBL.GetPackageTotalFixedPrice(CurrentPackage);
            }
            catch (Exception ex)
            {
                SetErrorMessage (ex, "calculating total fixed price");
            }
        }

        //perform the change of lines list in the view model
        private void EditLineByIdLocally(int lineId, Line newLine)
        {
            try { 
                Line oldLine = Lines.FirstOrDefault((Line line) => (line.Id == lineId));
                oldLine.Id = newLine.Id;
                oldLine.Number = newLine.Number;
                oldLine.PackageId = newLine.PackageId;
            }
            catch (Exception) { }
        }

        //remove line from the view model's Lines list
        private void DeleteLineByIdLocally(int id)
        {
            try
            {
                Lines.Remove(Lines.FirstOrDefault((Line line) => (line.Id == id)));
            }
            catch (Exception) { }
        }

        public IList<Line> Lines
        {
            get => _lines;
            set {
                SetProperty(ref _lines, value);
                SelectedLine = null;
            }
        }

        public int? ClientIdNumber
        {
            get => _clientIdNumber;
            set
            {
                SetProperty(ref _clientIdNumber, value);

                ResetMessages();

                if (_clientIdNumber != null)
                {
                    
                    Client client;
                    try
                    {
                        //get client data
                        client = clientInfoBL.GetClientByIdNumber((int)_clientIdNumber);
                    }
                    catch (Exception ex)
                    {
                        ClientAsString = "-";
                        SetErrorMessage(ex, "loading client");
                        return;
                    }

                    _clientId = client.Id;
                    ClientAsString = client.ClientIdNumber + " - " + client.Name + " " + client.LastName;
                    
                    try
                    {
                        
                        Lines = ListToObservableCollection(lineInfoBL.GetClientLines((int)_clientId));

                        if (Lines == null)
                            Lines = new ObservableCollection<Line>();

                    }
                    catch (Exception ex)
                    {
                        SetErrorMessage(ex, "loading lines");
                        return;
                    }

                    try
                    {
                        _packages = lineInfoBL.GetPackages();
                        if (_packages == null)
                            _packages = new List<Package>();
                    }
                    catch (Exception ex)
                    {
                        SetErrorMessage(ex, "loading packages");
                        _lines.Clear();
                        _lines = null;
                        return;

                    }
                }
                else
                {
                    ClientAsString = "(Not provided)";
                    ErrorMessage = "client was not provided";
                }
            }
        }

        public List<Package> Packages { get => _packages;
            set
            {
                SetProperty(ref _packages, value);
                SelectedPackage = null;
            }
        }

        public Package SelectedPackage
        {
            get => _selectedPackage;
            set
            {

                SetProperty(ref _selectedPackage, value);
                if (_selectedPackage != null)
                {
                    ResetMessages();

                    if (_selectedPackage.FavouriteNumbers != null)
                    {
                        try
                        {
                            //get selectedNumbers of the selected package
                            _selectedPackage.SelectedNumbers = lineInfoBL.GetSelectedNumbersById((int)_selectedPackage.FavouriteNumbers);
                        }
                        catch (Exception ex)
                        {
                            SetErrorMessage(ex, "loading package");
                            SelectedPackage = null;
                            return;
                        }
                    }

                    //make a copy of selected numbers rather than using the original
                    //so that when selecting same package later we dont see possible changes
                    //in selected package's selected numbers
                    SelectedNumbers selectedNumbersCopy = (_selectedPackage.SelectedNumbers != null) ?
                        new SelectedNumbers
                        {
                            Id = SelectedPackage.SelectedNumbers.Id,
                            FirstNumber = SelectedPackage.SelectedNumbers.FirstNumber,
                            SecondNumber = SelectedPackage.SelectedNumbers.SecondNumber,
                            ThirdNumber = SelectedPackage.SelectedNumbers.ThirdNumber
                        }
                        :
                        new SelectedNumbers();


                    //make a copy of current package using the original for similar reason
                    CurrentPackage = new Package
                    {
                        DiscountPercentage = SelectedPackage.DiscountPercentage,
                        FavouriteNumbers = SelectedPackage.FavouriteNumbers,
                        FixedPrice = SelectedPackage.FixedPrice,
                        Id = SelectedPackage.Id,
                        InsideFamilyCalls = SelectedPackage.InsideFamilyCalls,
                        MaxMinute = SelectedPackage.MaxMinute,
                        MostCalledNumber = SelectedPackage.MostCalledNumber,
                        PackageName = SelectedPackage.PackageName,
                        SelectedNumbers = selectedNumbersCopy

                    };

                }
                else
                {
                    CurrentPackage = new Package();
                    CurrentPackage.SelectedNumbers = new SelectedNumbers();
                }

                _saveCommand.InvokeCanExecuteChanged();
                _deleteCommand.InvokeCanExecuteChanged();
                _calcTotalFixedPriceCommand.InvokeCanExecuteChanged();
            }
        }
        

        public Line SelectedLine
        {
            get => _selectedLine;

            set
            {
                SetProperty(ref _selectedLine, value);

                ResetMessages();             

                if (_selectedLine != null) {
                    SelectedLineNumber = _selectedLine.Number;
                    if (_selectedLine.PackageId != null) {
                        try { 
                            //get package of selected line
                            SelectedPackage = lineInfoBL.GetPackageById((int)_selectedLine.PackageId);
                        }
                        catch (Exception ex)
                        {
                            SetErrorMessage(ex, "loading package");
                            return;
                        }
                    }
                    else
                    {
                        SelectedPackage = null;
                    }
                    
                }
                else
                {
                    SelectedPackage = null;
                    SelectedLineNumber = null;
                }

                lineChanged = false;

                _deleteCommand.InvokeCanExecuteChanged();
                _saveCommand.InvokeCanExecuteChanged();

            }

        }
        public string SelectedLineNumber
        {
            get => _selectedLineNumber;
            set
            {
                if (_selectedLineNumber != value)
                    lineChanged = true;

                SetProperty(ref _selectedLineNumber, value);
            }

        }
        public bool CurrentPackageXminYpriceChecked
        {
            get => _currentPackageXminYpriceChecked;
            set
            {
                SetProperty(ref _currentPackageXminYpriceChecked, value);

                if (_currentPackageXminYpriceChecked == false)
                {
                    //update relevant check box
                    if (!isEmptyField(CurrentPackageMinutes) || !(isEmptyField(CurrentPackagePrice)))
                        CurrentPackageXminYpriceChecked = true;
                }
            }
        }
        public int? CurrentPackageMinutes
        {
            get => _currentPackageMinutes;
            set
            {
                SetProperty(ref _currentPackageMinutes, value);

                if (_currentPackage!=null)
                    _currentPackage.MaxMinute = _currentPackageMinutes;
                //update relevant check box
                CurrentPackageXminYpriceChecked = (_currentPackagePrice != null || _currentPackageMinutes != null);

            }
        }
        public double? CurrentPackagePrice
        {
            get => _currentPackagePrice;
            set
            {
                SetProperty(ref _currentPackagePrice, value);

                if (_currentPackage != null)
                    _currentPackage.FixedPrice = _currentPackagePrice;

                //update relevant check box
                CurrentPackageXminYpriceChecked = (_currentPackagePrice != null || _currentPackageMinutes != null);
            }
        }
        public double? CurrentPackageDiscountPercentage
        {
            get => _currentPackageDiscountPercentage;
            set
            {
                SetProperty(ref _currentPackageDiscountPercentage, value);

                if (_currentPackage != null)
                    _currentPackage.DiscountPercentage = _currentPackageDiscountPercentage;

                if (_currentPackageDiscountPercentage != null)
                {
                    //update relevant check box
                    CurrentPackageFriendsChecked = true;
                }
            }
        }
        public bool CurrentPackageFamilyDiscountChecked
        {
            get => _currentPackageFamilyDiscountChecked;
            set
            {
                SetProperty(ref _currentPackageFamilyDiscountChecked, value);

                if (_currentPackage != null)
                    _currentPackage.InsideFamilyCalls = _currentPackageFamilyDiscountChecked;

            }
        }
        public bool CurrentPackageFriendsChecked
        {
            get => _currentPackageFriendsChecked;
            set
            {
                SetProperty(ref _currentPackageFriendsChecked, value);

                if (_currentPackageFriendsChecked == false)
                {
                    //update relevant check box
                    if (!isEmptyField(CurrentPackageFriendNumber1) || !isEmptyField(CurrentPackageFriendNumber2) || !isEmptyField(CurrentPackageFriendNumber3))
                        CurrentPackageFriendsChecked = true;
                    else if (!isEmptyField(CurrentPackageDiscountPercentage))
                        CurrentPackageFriendsChecked = true;
                }

            }
        }
        public string CurrentPackageFriendNumber1
        {
            get => _currentPackageFriendNumber1;
            set
            {
                if (_currentPackageFriendNumber1 != value)
                {

                    selectedNumbersChanged = true;
                }

                SetProperty(ref _currentPackageFriendNumber1, value);

                //update current package's data
                if (_currentPackage!= null)
                    if (_currentPackage.SelectedNumbers != null)
                        _currentPackage.SelectedNumbers.FirstNumber = _currentPackageFriendNumber1;

                if (!isEmptyField(_currentPackageFriendNumber1))
                {
                    //update relevant check box
                    CurrentPackageFriendsChecked = true;
                }
            }
        }
        public string CurrentPackageFriendNumber2
        {
            get => _currentPackageFriendNumber2;
            set
            {
                if (_currentPackageFriendNumber2 != value)
                {
                    selectedNumbersChanged = true;
                }

                SetProperty(ref _currentPackageFriendNumber2, value);

                if (_currentPackage != null)
                    if (_currentPackage.SelectedNumbers != null)
                        _currentPackage.SelectedNumbers.SecondNumber = _currentPackageFriendNumber2;

                if (!isEmptyField(_currentPackageFriendNumber2))
                {
                    CurrentPackageFriendsChecked = true;
                }
            }
        }
        public string CurrentPackageFriendNumber3
        {
            get => _currentPackageFriendNumber3;
            set
            {
                if (_currentPackageFriendNumber3 != value)
                {
                    selectedNumbersChanged = true;
                }
                SetProperty(ref _currentPackageFriendNumber3, value);

                if (_currentPackage != null)
                    if (_currentPackage.SelectedNumbers != null)
                        _currentPackage.SelectedNumbers.ThirdNumber = _currentPackageFriendNumber3;

                if (!isEmptyField(_currentPackageFriendNumber3))
                {
                    CurrentPackageFriendsChecked = true;
                }
            }
        }
        public SelectedNumbers CurrentPackageFriendNumbers {
            get =>_currentPackageFriendNumbers;
            set {

                CurrentPackageFriendsChecked = false;

                SetProperty(ref _currentPackageFriendNumbers, value);
                //update fields
                if (_currentPackageFriendNumbers != null)
                {
                    
                    CurrentPackageFriendNumber1 = _currentPackageFriendNumbers.FirstNumber;
                    CurrentPackageFriendNumber2 = _currentPackageFriendNumbers.SecondNumber;
                    CurrentPackageFriendNumber3 = _currentPackageFriendNumbers.ThirdNumber;
                }
                else
                {
                    CurrentPackageFriendNumber1 = null;
                    CurrentPackageFriendNumber2 = null;
                    CurrentPackageFriendNumber3 = null;
                }
                selectedNumbersChanged = false;
            }
        }
        public bool CurrentPackageFavouriteNumberChecked
        {
            get => _currentPackageFavouriteNumberChecked;
            set
            {
                SetProperty(ref _currentPackageFavouriteNumberChecked, value);

                if (_currentPackage != null)
                    _currentPackage.MostCalledNumber = _currentPackageFavouriteNumberChecked;
            }
        }
        public double? CurrentPackageTotalFixedPrice
        {
            get => _currentPackageTotalFixedPrice;
            set
            {
                SetProperty(ref _currentPackageTotalFixedPrice, value);
            }
        }

        /// <summary>
        /// client's display name
        /// </summary>
        public string ClientAsString { get => _clientAsString; set => SetProperty(ref _clientAsString, value); }

        public Package CurrentPackage
        {
            get => _currentPackage;
            set
            {
                SetProperty(ref _currentPackage ,value);
                
                if (_currentPackage != null)
                {
                    //update fields
                    CurrentPackageMinutes = _currentPackage.MaxMinute;
                    CurrentPackagePrice = _currentPackage.FixedPrice;
                    CurrentPackageFamilyDiscountChecked = _currentPackage.InsideFamilyCalls;
                    CurrentPackageFavouriteNumberChecked = _currentPackage.MostCalledNumber;
                    CurrentPackageDiscountPercentage = _currentPackage.DiscountPercentage;

                    if (_currentPackage.SelectedNumbers != null)
                        CurrentPackageFriendNumbers = _currentPackage.SelectedNumbers;
                    else
                        CurrentPackageFriendNumbers = new SelectedNumbers();
                    
                    try
                    {
                        CurrentPackageTotalFixedPrice = lineInfoBL.GetPackageTotalFixedPrice(_currentPackage);
                    }
                    catch (Exception ex)
                    {
                        SetErrorMessage (ex,"calculating total fixed price");
                    }
                }
                else
                {
                    CurrentPackageFriendNumbers = new SelectedNumbers();
                }
            }
        }

        public int? UserId { get => _userId; set => _userId=value; }

        private bool checkFields()
        {
            bool ret = false;
            ResetMessages();
            const string STR_REQIRED_FIELD = "Required field: ";

            if (isEmptyField(SelectedLineNumber))
                ErrorMessage = STR_REQIRED_FIELD + "Number";
            else if (CurrentPackageXminYpriceChecked == true && isEmptyField(CurrentPackageMinutes))
                ErrorMessage = STR_REQIRED_FIELD + "Minutes in XminYprice";
            else if (CurrentPackageXminYpriceChecked == true && isEmptyField(CurrentPackagePrice))
                ErrorMessage = STR_REQIRED_FIELD + "Price in XminYprice";
            else if (CurrentPackageFriendsChecked == true && isEmptyField(CurrentPackageFriendNumber1) && isEmptyField(CurrentPackageFriendNumber2) && isEmptyField(CurrentPackageFriendNumber3))
                ErrorMessage = "No friend numbers provided";
            else if (CurrentPackageFriendsChecked == true && isEmptyField(CurrentPackageDiscountPercentage))
                ErrorMessage = STR_REQIRED_FIELD + "Discount Percentage";
            else
                ret = true;

            return ret;
        }

        /// <summary>
        /// checks whether to set selected numbers of current package to null or not
        /// </summary>
        private bool CurrentPackageSelectedNumbersNotEmpty()
        {
            bool ret = false;
            if (!isEmptyField(CurrentPackageFriendNumber1) || !isEmptyField(CurrentPackageFriendNumber2) || !isEmptyField(CurrentPackageFriendNumber3))
            {
                if (!isEmptyField(CurrentPackageDiscountPercentage))
                    ret = true;
            }
            return ret;
        }

        private bool CanSave(object parameter)
        {
            if (_clientId == null)
                return false;
            else
            {
                return true;
            }
        }
        private void OnSave(object parameter)
        {
            if (checkFields())
            {
                ResetMessages();

                int? selectedNumbersId=null;

                if (CurrentPackageSelectedNumbersNotEmpty())
                {
                    //use current selected numbers' id for package unless new selected numbers are in the fields
                    selectedNumbersId = CurrentPackageFriendNumbers.Id;

                    if (selectedNumbersChanged)
                    {
                        //add new selected numbers
                        try
                        {
                            selectedNumbersId =
                            lineInfoBL.AddSelectedNumbers(CurrentPackageFriendNumbers);

                        }
                        catch (Exception ex)
                        {
                            SetErrorMessage(ex, "saving package");
                            return;
                        }
                    }
                }

                CurrentPackage.FavouriteNumbers = selectedNumbersId;

                int packageId=0;
                
                try
                {
                    packageId=lineInfoBL.AddPackage(CurrentPackage);
                }
                catch (Exception ex)
                {

                    SetErrorMessage(ex, "adding package");
                    return;
                }
                CurrentPackage.Id = packageId;
                
                Line line;
                if (lineChanged)
                {
                    //update line

                    line = new Line
                    {
                        ClientId = (int)_clientId,
                        Number = SelectedLineNumber,
                        PackageId = CurrentPackage.Id
                    };

                    if (_userId == null)
                    {
                        //just in case the view model didn't successfully get employee's user id
                        ErrorMessage = "cannot add line - unknown employee";
                        return;
                    }
                    else
                    {

                        try
                        {
                            line.Id = lineInfoBL.AddLine(line,(int) _userId);
                            Lines.Add(line);
                            SelectedLine = line;
                            InfoMessage = "Line added";
                        }
                        catch (Exception ex)
                        {
                            SetErrorMessage(ex, "adding line");
                        }
                    }
                    
                }
                else
                {

                    //add new line

                    line = new Line
                    {
                        Id = SelectedLine.Id,
                        ClientId = (int)_clientId,
                        Number = SelectedLineNumber,
                        PackageId = CurrentPackage.Id,
                    };
                    try
                    {
                       lineInfoBL.EditLine(line);
                        EditLineByIdLocally(SelectedLine.Id, line);
                        SelectedLine = line;
                        InfoMessage = "Line updated";
                    }
                    catch (Exception ex)
                    {
                        SetErrorMessage(ex, "editing line");
                    }
                    
                }

            }
           
        }

        private bool CanDelete(object parameter)
        {
            return SelectedLine != null;
        }
        private void OnDelete(object parameter)
        {
            ResetMessages();
            try
            {
                lineInfoBL.DeleteLine(SelectedLine.Id);
                DeleteLineByIdLocally(SelectedLine.Id);
                SelectedLine = null;
                InfoMessage = "Line deleted";
            }
            catch (Exception ex)
            {
                SetErrorMessage(ex, "deleting line");
            }
        }

        private void OnClear(object parameter)
        {
            ResetMessages();
            SelectedPackage = null;
            SelectedLine = null;
        }


    }
}
