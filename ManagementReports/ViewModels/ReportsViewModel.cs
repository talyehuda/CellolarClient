using Common.Model;
using Common.ModelToBlClient;
using LocalCommon.ViewModels;
using ManagementReports.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementReports.ViewModels
{
    public class ReportsViewModel:ViewModelBase
    {
        private BIReportsBL bIReportsBL;
        private BIReport _biReport;

        public BIReport BiReport { get => _biReport; set => SetProperty(ref _biReport, value); }

        public ReportsViewModel()
        {
            bIReportsBL = new BIReportsBL();

            ResetMessages();
            try
            {
                BiReport = bIReportsBL.GetBIReport();
            }
            catch(Exception ex)
            {
                SetErrorMessage(ex, "getting report");
            }
                        
        }
    }
}
