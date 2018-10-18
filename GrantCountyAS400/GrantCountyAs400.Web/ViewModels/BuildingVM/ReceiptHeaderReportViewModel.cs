using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GrantCountyAs400.Web.ViewModels.BuildingVM
{
    public class BuildingReceiptsReportViewModel
    {
        public List<ReceiptHeaderViewModel> ReceiptHeaders { get; set; }
        public List<BuildingApplicationFeeViewModel> Fees { get; set; }

        [Display(Name = "Fees")]
        public decimal TotalFees => Fees.Sum(t => t.ExtendedAmount).Value;
        [Display(Name = "Paid")]
        public decimal TotalPaid => ReceiptHeaders.Sum(t => t.CheckAmount + t.CashAmount + t.OtherAmount).Value;
        [Display(Name = "Balance")]
        public decimal Balance => (TotalFees - TotalPaid);
    }
}