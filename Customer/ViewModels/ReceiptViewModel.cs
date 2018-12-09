using Common.Model;
using LocalCommon.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LocalCommon.BL;
using Common.ModelToBlClient.Invoice;

namespace Customer.ViewModels
{
    class ReceiptViewModel:ViewModelBase
    {

        private ClientInfoBL clientInfoBL;
        private LineInfoBL lineInfoBL;
        private ReceiptBL receiptBL;

        private Func<ClientInvoice, bool> _acceptCallBack;
        private DelegateCommand _calculateCommand;
        public ICommand CalculateCommand { get => _calculateCommand; }

        private int? _clientId;
        private List<SelectableLine> _lines;
        private List<int> _months;
        private int? _selectedMonth;
        private List<int> _years;
        private int? _selectedYear;

        ClientInvoice _clientInvoice=null;

        public ReceiptViewModel()
        {
            clientInfoBL = new ClientInfoBL();
            lineInfoBL = new LineInfoBL();
            receiptBL = new ReceiptBL();

            _calculateCommand = new DelegateCommand(OnCalculate, CanCaluclate);


            // fill in 12 months for selection
            List<int> months = new List<int>();
            for (int i = 1; i <= 12; i++)
                months.Add(i);
            Months = months;

            //fill in last 25 years for selection
            List<int> years = new List<int>();
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 25; i--)
                years.Add(i);
            Years = years;
            SelectedYear = DateTime.Now.Year;
            SelectedMonth = DateTime.Now.Month;


        }


        private bool CanCaluclate(object parameter)
        {
            if (_clientId == null)
                return false;
            else if (_selectedMonth == null)
                return false;
            else if (_selectedYear == null)
                return false;
            else
                return true;
        }

        private bool CheckFields(IEnumerable<Line> selectedLines)
        {
            bool ret = false;
            ResetMessages();
            
            if (selectedLines == null || selectedLines.Count()== 0)
            {
                ErrorMessage = "No lines are selected";
            }
            else
                ret = true;
            return ret;

        }
        private void OnCalculate(object parameter)
        {
            List<Line> selectedLines = GetSelectedLines(Lines);
            if (CheckFields(selectedLines))
            {
                 ResetMessages();

                
                try
                {
                    //calculate...
                    _clientInvoice = receiptBL.GetClientInvoice(selectedLines,(int)SelectedMonth, (int)SelectedYear);
                    //pass the calculated invoice back
                    _acceptCallBack(_clientInvoice);
                }
                catch (Exception ex)
                {
                    SetErrorMessage (ex,"calculating receipts");
                }
            }
        }

        //convert List<Line> object to List<SelectableLine>
        private List<SelectableLine> LinesToSelectableLines(List<Line> lines)
        {
            if (lines == null)
                return null;

            List<SelectableLine> selectableLines = new List<SelectableLine>();
            foreach (var line in lines)
                selectableLines.Add(new SelectableLine(line));
            return selectableLines;
        }

        //gets List<Line> object from a List<SelectableLine> object where SelectableLine lines are selected
        private List<Line> GetSelectedLines(IEnumerable<SelectableLine> selectableLines)
        {
            if (selectableLines == null)
                return null;

            List<Line> lines = new List<Line>();
            foreach (var selectableLine in selectableLines)
            {
                if (selectableLine.IsSelected)
                    lines.Add(selectableLine.Item);
            }
            return lines;
        }

        //activated after the invoice is calculated for the user
        public Func<ClientInvoice, bool> AcceptCallBack { get => _acceptCallBack; set => _acceptCallBack = value; }

        public int? ClientId
        {
            get => _clientId;
            set
            {
                SetProperty(ref _clientId, value);
                if (_clientId != null)
                {
                    ResetMessages();
                    try
                    {
                        //fill in lines of selected client
                        Lines = LinesToSelectableLines(lineInfoBL.GetClientLines((int)_clientId));
                    }
                    catch (Exception ex)
                    {
                        SetErrorMessage(ex,"loading lines");
                    }
                    
                }
                _calculateCommand.InvokeCanExecuteChanged();
            }
        }
        public List<SelectableLine> Lines { get => _lines; set => SetProperty(ref _lines, value); }
        public List<int> Months { get => _months; set => SetProperty(ref _months, value); }
        public int? SelectedMonth { get => _selectedMonth; set
            {
                SetProperty(ref _selectedMonth, value);
                _calculateCommand.InvokeCanExecuteChanged();
            }
        }
        public List<int> Years { get => _years; set => SetProperty(ref _years, value); }
        public int? SelectedYear { get => _selectedYear;
            set
            {
                SetProperty(ref _selectedYear, value);
                _calculateCommand.InvokeCanExecuteChanged();
            }
        }

        public ClientInvoice ClientInvoice { get => _clientInvoice; }
    }
}
