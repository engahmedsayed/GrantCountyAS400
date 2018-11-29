using System;
using System.Collections.Generic;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class AcctPrWarrant
    {
        public int Id { get; set; }
        public decimal? Group { get; set; }
        public decimal WarrantNumber { get; set; }
        public decimal? CheckNumber { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ClearedDate { get; set; }
        public DateTime? VoidDate { get; set; }
        public decimal? Status { get; set; }
        public decimal? Prwstsqual { get; set; }
        public decimal? Prwstsupdt { get; set; }
        public decimal? Ssnubmer { get; set; }
        public decimal? EmployeeNumber { get; set; }
        public decimal? Count { get; set; }
        public string Name { get; set; }
        public decimal? Fund { get; set; }
        public decimal? Department { get; set; }
        public decimal? Type { get; set; }
        public decimal? Prwper { get; set; }
        public decimal? Prwpertype { get; set; }
        public decimal? Year { get; set; }
        public decimal? Month { get; set; }
        public decimal? Weeks { get; set; }
        public decimal? RetirementCode { get; set; }
        public string RetirementOption { get; set; }
        public DateTime? Prwretseldate { get; set; }
        public string Prwretselcode { get; set; }
        public string Prwretipmgr { get; set; }
        public string Prwadcode { get; set; }
        public string Prwadbrnch { get; set; }
        public string Prwbargunt { get; set; }
        public decimal? Gross { get; set; }
        public decimal? DeferredGross { get; set; }
        public decimal? NonTaxible { get; set; }
        public decimal? Taxable { get; set; }
        public decimal? FederalWithholding { get; set; }
        public decimal? State { get; set; }
        public decimal? Fica { get; set; }
        public decimal? FicaBenefits { get; set; }
        public decimal? NetPay { get; set; }
        public decimal? FicaGrossPay { get; set; }
        public decimal? RetirementGross { get; set; }
        public decimal? RetirementPay { get; set; }
        public decimal? RetirementBenefitsEmployee { get; set; }
        public decimal? RetirementBenefitsEmployer { get; set; }
        public decimal? MedicalGross { get; set; }
        public decimal? Medical { get; set; }
        public decimal? MedicalBenefits { get; set; }
        public decimal? TaxableMedicalBenefits { get; set; }
    }
}
