using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GrantCountyAs400.PersistenceAdapter.Models
{
    public partial class GrantCountyDbContext : DbContext
    {
        public GrantCountyDbContext()
        {
        }

        public GrantCountyDbContext(DbContextOptions<GrantCountyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcctApWarrant> AcctApWarrant { get; set; }
        public virtual DbSet<AcctCategoryCodes> AcctCategoryCodes { get; set; }
        public virtual DbSet<AcctChartOfAccounts> AcctChartOfAccounts { get; set; }
        public virtual DbSet<AcctEmployee> AcctEmployee { get; set; }
        public virtual DbSet<AcctEmployeeMiscDeductions> AcctEmployeeMiscDeductions { get; set; }
        public virtual DbSet<AcctEmployeeYtdhistory> AcctEmployeeYtdhistory { get; set; }
        public virtual DbSet<AcctGeneralLedger> AcctGeneralLedger { get; set; }
        public virtual DbSet<AcctGlperiodAmounts> AcctGlperiodAmounts { get; set; }
        public virtual DbSet<AcctGltransactions> AcctGltransactions { get; set; }
        public virtual DbSet<AcctPayrollJobCodes> AcctPayrollJobCodes { get; set; }
        public virtual DbSet<AcctPersonnel> AcctPersonnel { get; set; }
        public virtual DbSet<AcctPrWarrant> AcctPrWarrant { get; set; }
        public virtual DbSet<AcctVendor> AcctVendor { get; set; }
        public virtual DbSet<AsmtfullLegalDescription> AsmtfullLegalDescription { get; set; }
        public virtual DbSet<AsmtlandUseCodes> AsmtlandUseCodes { get; set; }
        public virtual DbSet<AsmtmasterNameAddress> AsmtmasterNameAddress { get; set; }
        public virtual DbSet<AsmtmobileHomeParks> AsmtmobileHomeParks { get; set; }
        public virtual DbSet<AsmtparentChildRelationshipsChanged> AsmtparentChildRelationshipsChanged { get; set; }
        public virtual DbSet<AsmtplatCondoMaster> AsmtplatCondoMaster { get; set; }
        public virtual DbSet<AsmtrealPropertyAssessedValueMaster> AsmtrealPropertyAssessedValueMaster { get; set; }
        public virtual DbSet<AsmtrealPropertyAssociatedPersons> AsmtrealPropertyAssociatedPersons { get; set; }
        public virtual DbSet<AsmttaxCodeArea> AsmttaxCodeArea { get; set; }
        public virtual DbSet<AsmtzoneDescriptions> AsmtzoneDescriptions { get; set; }
        public virtual DbSet<ASMTValueMasterNameView> ASMTValueMasterNameView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcctApWarrant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Bank)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Base)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CheckNumber).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Combine)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FillType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYear).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Fund)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Invoice)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.PayDate).HasColumnType("date");

                entity.Property(e => e.PayType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Program)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VendorType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WarrantDate).HasColumnType("date");

                entity.Property(e => e.WarrantNumber).HasColumnType("decimal(6, 0)");
            });

            modelBuilder.Entity<AcctCategoryCodes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(13, 4)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryAbbreviation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryDescription)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Cdcmt)
                    .HasColumnName("CDCMT")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.System)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcctChartOfAccounts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcctCategory)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AcctDescription)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AcctNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYear).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<AcctEmployee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnniversaryDate).HasColumnType("date");

                entity.Property(e => e.BargainingUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BondCurrent).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.BondPurchased).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.BondType).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Branch)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Budget)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Count).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.CurrentFederalWithholding).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentFica).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentFicaBenefit).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentFicaGross).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentGross).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentMedical).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentMedicalBenefit).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentMedicalGross).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentNetPay).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentNonTaxable).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentRetirement).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentRetirementBenefit).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentRetirementGross).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentStateWithholding).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentTax).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentTaxable).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CurrentTaxableBenefit).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Date1).HasColumnType("date");

                entity.Property(e => e.Date2).HasColumnType("date");

                entity.Property(e => e.Department).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Emadaccnt)
                    .HasColumnName("EMADACCNT")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Embondcnt)
                    .HasColumnName("EMBONDCNT")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Emcamtreg)
                    .HasColumnName("EMCAMTREG")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Emcdeds)
                    .HasColumnName("EMCDEDS")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Emcdefd)
                    .HasColumnName("EMCDEFD")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Emchrsreg)
                    .HasColumnName("EMCHRSREG")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Emcretemp)
                    .HasColumnName("EMCRETEMP")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Emhldytakn)
                    .HasColumnName("EMHLDYTAKN")
                    .HasColumnType("decimal(1, 0)");

                entity.Property(e => e.EmpEeofunction)
                    .HasColumnName("EmpEEOFunction")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFicaCode).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.EmpFicaExempt).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.EmpFilled).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.EmpLongevity).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.EmpLongevityAmount).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.EmpPercent).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.EmpSaif).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.EmpWarrantNumber).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Emretipmgr)
                    .HasColumnName("EMRETIPMGR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Emretselcode)
                    .HasColumnName("EMRETSELCODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Emretseldate)
                    .HasColumnName("EMRETSELDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Emsftabl)
                    .HasColumnName("EMSFTABL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Emupdtcnt)
                    .HasColumnName("EMUPDTCNT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Emupdtflag)
                    .HasColumnName("EMUPDTFLAG")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Emupdtlast)
                    .HasColumnName("EMUPDTLAST")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Emweeksqtd)
                    .HasColumnName("EMWEEKSQTD")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Flsa)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fund).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Grade)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Group).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LastHistory).HasColumnType("date");

                entity.Property(e => e.MeritStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Number).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.OldRate).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.PayCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.QtrltRetirementBenefitEmployer).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyDeferredGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyFederalWihholding).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyFica).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyFicaBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyFicaGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyMedical).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyMedicalBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyMedicalGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyNetPay).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyNonTaxable).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyRetirement).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyRetirementBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyRetirementGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyStateWithholding).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyTaxable).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.QtrlyTaxableBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.RetirementCode).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RetirementFlag).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RetirementLock).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RetirementNumber).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.RetirementOption)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.Property(e => e.ServiceDate).HasColumnType("date");

                entity.Property(e => e.ServiceYears).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Ssnumber)
                    .HasColumnName("SSNumber")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Step)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Table)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.TerminationType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Weeks).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Year).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.YearlyDeferredGross).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyFederalWithholding).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyFica).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyFicaBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyFicaGross).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyGross).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyMedical).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyMedicalBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyMedicalGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyNetPay).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyNontaxable).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyRetirement).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyRetirementBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyRetirementBenefitEmployer).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyRetirementGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyStateWithholding).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyTaxable).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyTaxableBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyTotalPay).HasColumnType("decimal(11, 2)");
            });

            modelBuilder.Entity<AcctEmployeeMiscDeductions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeNumber).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.MiscBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MiscCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MiscCount).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.MiscDeduction).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MiscGroup).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.MiscTaxLimit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MiscYear).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Section145)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcctEmployeeYtdhistory>(entity =>
            {
                entity.ToTable("AcctEmployeeYTDHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BargainingUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BondCurrent).HasColumnType("decimal(7, 0)");

                entity.Property(e => e.BondPurchase).HasColumnType("decimal(7, 0)");

                entity.Property(e => e.BondType).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Count).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Department).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Embondcnt)
                    .HasColumnName("EMBONDCNT")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.EmpJobCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Emsftabl)
                    .HasColumnName("EMSFTABL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FicaCode).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.FicaExempt).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Filled).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.Flsa)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fund).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Grade)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Group).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Longevity).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.MeritFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Number).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.PayCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PayStatus).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.Percent).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.RetirementCode).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RetirementFlag).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.RetirementNumber).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Saif).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Ssnumber)
                    .HasColumnName("SSNumber")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Step)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Table)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Year).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.YearlyFederalWithholding).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyFica).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyFicaBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyFicaGross).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyGrossPay).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyGrossPayDeferred).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyMedical).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyMedicalBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyMedicalGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyNetPay).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyNonTaxable).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyRetirement).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyRetirementBenefitEmployee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyRetirementBenefitEmployer).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyRetirementGross).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyStatWithholding).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyTaxable).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.YearlyTaxableBenefit).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.YearlyTotalPay).HasColumnType("decimal(11, 2)");
            });

            modelBuilder.Entity<AcctGeneralLedger>(entity =>
            {
                entity.HasIndex(e => e.Fund)
                    .HasName("IX_AcctGeneralLedger");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Base)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BeginBudget).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.ClosedAcct)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentAction).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.CurrentBudget).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.CurrentEncumbrance).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Department)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYear).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Fund)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NetBalance).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.PendingAction).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.PendingEncumbrance).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Program)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecordType)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcctGlperiodAmounts>(entity =>
            {
                entity.ToTable("AcctGLPeriodAmounts");

                entity.HasIndex(e => e.Fund)
                    .HasName("IX_AcctGLPeriodAmounts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Base)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Budget).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Department)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Encumbrance).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.FiscalYear).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Fund)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Glppenact)
                    .HasColumnName("GLPPENACT")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Month).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.PendingEncumbrance).HasColumnType("decimal(11, 0)");

                entity.Property(e => e.Program)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Year).HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<AcctGltransactions>(entity =>
            {
                entity.ToTable("AcctGLTransactions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Base)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalYear).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Fund)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Jenumber)
                    .HasColumnName("JENumber")
                    .HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Line).HasColumnType("decimal(4, 0)");

                entity.Property(e => e.Month).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Notation1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Notation2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Notation3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Notation4)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Program)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Year).HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<AcctPayrollJobCodes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Experience)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Group).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.JobCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnName("JobTitle ")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Prjcmt)
                    .HasColumnName("PRJCMT")
                    .HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Prjgrdfrom)
                    .HasColumnName("PRJGRDFROM")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Prjgrdto)
                    .HasColumnName("PRJGRDTO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Prjtabfrom)
                    .HasColumnName("PRJTABFROM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Prjtabto)
                    .HasColumnName("PRJTABTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcctPersonnel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AddressFlag).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.BloodType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DriverLicenseNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContact)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactAddress1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactAddress2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactPhone).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.EmergencyContactState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactZip).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.FedMarriedStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FedMarriedStatusDependents).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Group).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.LicenseExpDate).HasColumnType("date");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MilitaryBranch)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MilitaryDischargeDate).HasColumnType("date");

                entity.Property(e => e.MilitaryDischargeType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PersMarriedStatus).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.PersMarriedStatusDep).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.PersonNumber).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Phone).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Prbenefic)
                    .HasColumnName("PRBENEFIC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Predfield)
                    .HasColumnName("PREDFIELD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Predhs)
                    .HasColumnName("PREDHS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Predlevel)
                    .HasColumnName("PREDLEVEL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Predlstdt)
                    .HasColumnName("PREDLSTDT")
                    .HasColumnType("date");

                entity.Property(e => e.Prflsa)
                    .HasColumnName("PRFLSA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Prime).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Prlsthist)
                    .HasColumnName("PRLSTHIST")
                    .HasColumnType("date");

                entity.Property(e => e.Prmilstats)
                    .HasColumnName("PRMILSTATS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Prstfield)
                    .HasColumnName("PRSTFIELD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Prupdcnt)
                    .HasColumnName("PRUPDCNT")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Prupdlast)
                    .HasColumnName("PRUPDLAST")
                    .HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Race)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ssnumber)
                    .HasColumnName("SSNumber")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateMarriedStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateMarriedStatusDep).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Status).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.TotalJobs).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.UpdateFlag).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.ZipCode).HasColumnType("decimal(9, 0)");
            });

            modelBuilder.Entity<AcctPrWarrant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckNumber).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.ClearedDate).HasColumnType("date");

                entity.Property(e => e.Count).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeferredGross).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Department).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.EmployeeNumber).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.FederalWithholding).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Fica).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.FicaBenefits).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.FicaGrossPay).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Fund).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.Gross).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Group).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.MedicalBenefits).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.MedicalGross).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Month).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NetPay).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.NonTaxible).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Prwadbrnch)
                    .HasColumnName("PRWADBRNCH")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Prwadcode)
                    .HasColumnName("PRWADCODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Prwbargunt)
                    .HasColumnName("PRWBARGUNT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Prwmed)
                    .HasColumnName("PRWMED")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Prwper)
                    .HasColumnName("PRWPER")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Prwpertype)
                    .HasColumnName("PRWPERTYPE")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Prwretipmgr)
                    .HasColumnName("PRWRETIPMGR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Prwretselcode)
                    .HasColumnName("PRWRETSELCODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Prwretseldate)
                    .HasColumnName("PRWRETSELDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Prwstsqual)
                    .HasColumnName("PRWSTSQUAL")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Prwstsupdt)
                    .HasColumnName("PRWSTSUPDT")
                    .HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RetirementBenefitsEmployee).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RetirementBenefitsEmployer).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RetirementCode).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.RetirementGross).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RetirementOption)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RetirementPay).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Ssnubmer)
                    .HasColumnName("SSNubmer")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.State).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Status).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Taxable).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.TaxableMedicalBenefits).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Type).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.VoidDate).HasColumnType("date");

                entity.Property(e => e.WarrantNumber).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.Weeks).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Year).HasColumnType("decimal(4, 0)");
            });

            modelBuilder.Entity<AcctVendor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayFlag)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Number).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.OldKey)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalCity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalZipCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalZipCodeSuffix)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Representative)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentativeKind)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCodeSuffix)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsmtfullLegalDescription>(entity =>
            {
                entity.ToTable("ASMTFullLegalDescription");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descrtiption)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Filler)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SequenceNumber).HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<AsmtlandUseCodes>(entity =>
            {
                entity.ToTable("ASMTLandUseCodes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbstractCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Filler)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.LandUseCode).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UseCodeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UseCodeShortDesc)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsmtmasterNameAddress>(entity =>
            {
                entity.ToTable("ASMTMasterNameAddress");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Casscertified)
                    .HasColumnName("CASSCertified")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NameChangeDate).HasColumnType("date");

                entity.Property(e => e.NameChangeId)
                    .HasColumnName("NameChangeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameChangeReason)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NameCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NameFormat)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxServiceCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ZipDeliveryPoint)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsmtmobileHomeParks>(entity =>
            {
                entity.ToTable("ASMTMobileHomeParks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNameCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Filler01)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MhparkCode)
                    .HasColumnName("MHParkCode")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.QualCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpaceNumber).HasColumnType("decimal(5, 0)");

                entity.Property(e => e.TelephoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsmtparentChildRelationshipsChanged>(entity =>
            {
                entity.ToTable("ASMTParentChildRelationshipsChanged");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssociatedParcelTax)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChildParcel).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.LegalDocumentType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ParentParcel).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SegCombDate).HasColumnType("date");
            });

            modelBuilder.Entity<AsmtplatCondoMaster>(entity =>
            {
                entity.ToTable("ASMTPlatCondoMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acres).HasColumnType("decimal(5, 0)");

                entity.Property(e => e.AppraiserCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("ChangeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CommentLine1)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.CommentLine2)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.CommentLine3)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.CommentLine4)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.CommentLine5)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.FieldBook).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.HangerNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Page).HasColumnType("numeric(4, 1)");

                entity.Property(e => e.PlatAbbreviation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PlatCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PlatCodeType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlatDate).HasColumnType("date");

                entity.Property(e => e.PlatNameDesc)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Range).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevalutionPhase)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Section).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Township).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Volume).HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<AsmtrealPropertyAssessedValueMaster>(entity =>
            {
                entity.ToTable("ASMTRealPropertyAssessedValueMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AffidavitAssessmentYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.AffidavitNumber).HasColumnType("numeric(9, 0)");

                entity.Property(e => e.AffidavitTaxYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.AnnexationSpecialCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AssocMhparcel)
                    .HasColumnName("AssocMHParcel")
                    .HasColumnType("numeric(16, 0)");

                entity.Property(e => e.BlockNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingValue).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("ChangeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeFirePatrolAssmYn)
                    .HasColumnName("ChargeFirePatrolAssmYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContractHolder)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CuimprovedLandValue)
                    .HasColumnName("CUImprovedLandValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.CutimberlandValue)
                    .HasColumnName("CUTimberlandValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.CuunimprovedLandValue)
                    .HasColumnName("CUUnimprovedLandValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Description1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Description3)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Description4)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Description5)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DockNumber)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Filler)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Filler04A)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Filler04B)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Filler06A)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Filler1)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Filler18A)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FirePatrolAcres).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FmbuildingValue)
                    .HasColumnName("FMBuildingValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.FmimprovedLandValue)
                    .HasColumnName("FMImprovedLandValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.FmtimberValue)
                    .HasColumnName("FMTimberValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.FmunimprovedLandValue)
                    .HasColumnName("FMUnimprovedLandValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.ImprovedLandAcers).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ImprovedLandValue).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.LandUseCode).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.LienDate).HasColumnType("date");

                entity.Property(e => e.LienType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LoanNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MobileHomeValue).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NameChangeDate).HasColumnType("date");

                entity.Property(e => e.NameChangeId)
                    .HasColumnName("NameChangeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameChangeReason)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OldTrayNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OpenSpaceAgreementNum).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.OpenspaceApplicationNum).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OriginalTaxNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.PlatCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PlatCodeType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevalutionPhase)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTaxableValues)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubsidiaryParcelCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCodeArea).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxpayerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TimberAcers).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TimberBaseValue).HasColumnType("decimal(7, 0)");

                entity.Property(e => e.TimberlandValue).HasColumnType("decimal(7, 0)");

                entity.Property(e => e.TitleOwnerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UndividedInterestPercent).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.UnimprovedLandAcres).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UnimprovedLandValue).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.UnitNumber)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsmtrealPropertyAssociatedPersons>(entity =>
            {
                entity.ToTable("ASMTRealPropertyAssociatedPersons");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("ChangeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Filler01)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NameCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsmttaxCodeArea>(entity =>
            {
                entity.ToTable("ASMTTaxCodeArea");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExciseAreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Filler)
                    .HasMaxLength(68)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevaluationPhase)
                    .HasColumnName("Revaluation Phase")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCodeArea).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxCodeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TaxDistirct)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsmtzoneDescriptions>(entity =>
            {
                entity.ToTable("ASMTZoneDescriptions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Filler)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCodeDesc)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCodeShortDesc)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneMinimums)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });
        }
    }
}
