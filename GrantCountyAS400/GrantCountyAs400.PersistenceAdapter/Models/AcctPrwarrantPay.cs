using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctPrwarrantPay
    {
        public decimal? Group { get; set; }
        public decimal? WarrantNumber { get; set; }
        public decimal? PayFlag { get; set; }
        public decimal? HoursWorked { get; set; }
        public decimal? PayAmount { get; set; }
        public decimal? WarrantStatus { get; set; }
        public decimal? PayValue { get; set; }
        public int Id { get; set; }
    }
}
