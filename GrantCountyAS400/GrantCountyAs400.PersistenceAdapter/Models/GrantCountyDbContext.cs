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
        public virtual DbSet<AsmtcityCodeFile> AsmtcityCodeFile { get; set; }
        public virtual DbSet<AsmtfullLegalDescription> AsmtfullLegalDescription { get; set; }
        public virtual DbSet<AsmtinstrumentType> AsmtinstrumentType { get; set; }
        public virtual DbSet<AsmtlandUseCodes> AsmtlandUseCodes { get; set; }
        public virtual DbSet<AsmtlegalDocuments> AsmtlegalDocuments { get; set; }
        public virtual DbSet<AsmtmasterNameAddress> AsmtmasterNameAddress { get; set; }
        public virtual DbSet<AsmtmobileHomeParks> AsmtmobileHomeParks { get; set; }
        public virtual DbSet<AsmtnameChangeHistory> AsmtnameChangeHistory { get; set; }
        public virtual DbSet<AsmtnewConstruction> AsmtnewConstruction { get; set; }
        public virtual DbSet<AsmtnotesAndComments> AsmtnotesAndComments { get; set; }
        public virtual DbSet<AsmtparentChildRelationshipsChanged> AsmtparentChildRelationshipsChanged { get; set; }
        public virtual DbSet<AsmtparentChildRelationshipsNew> AsmtparentChildRelationshipsNew { get; set; }
        public virtual DbSet<AsmtpermitMaster> AsmtpermitMaster { get; set; }
        public virtual DbSet<AsmtplatCondoMaster> AsmtplatCondoMaster { get; set; }
        public virtual DbSet<AsmtrealPropertyAssessedValueMaster> AsmtrealPropertyAssessedValueMaster { get; set; }
        public virtual DbSet<AsmtrealPropertyAssociatedPersons> AsmtrealPropertyAssociatedPersons { get; set; }
        public virtual DbSet<AsmtsalesAndExciseTaxData> AsmtsalesAndExciseTaxData { get; set; }
        public virtual DbSet<AsmtsalesRejectionReasonCodes> AsmtsalesRejectionReasonCodes { get; set; }
        public virtual DbSet<AsmtseniorCitizenHistory> AsmtseniorCitizenHistory { get; set; }
        public virtual DbSet<AsmtsenirCitizenExemptionRate> AsmtsenirCitizenExemptionRate { get; set; }
        public virtual DbSet<AsmtsitusAddress> AsmtsitusAddress { get; set; }
        public virtual DbSet<AsmttaxCodeArea> AsmttaxCodeArea { get; set; }
        public virtual DbSet<AsmtzoneDescriptions> AsmtzoneDescriptions { get; set; }
        public virtual DbSet<ASMTValueMasterNameView> ASMTValueMasterNameView { get; set; }
        public virtual DbSet<BldgapplcationReceiptDetail> BldgapplcationReceiptDetail { get; set; }
        public virtual DbSet<BldgapplcationReceiptHeader> BldgapplcationReceiptHeader { get; set; }
        public virtual DbSet<BldgapplicationConditions> BldgapplicationConditions { get; set; }
        public virtual DbSet<BldgapplicationFees> BldgapplicationFees { get; set; }
        public virtual DbSet<BldgapplicationInspections> BldgapplicationInspections { get; set; }
        public virtual DbSet<BldgapplicationNotes> BldgapplicationNotes { get; set; }
        public virtual DbSet<BldgapplicationValues> BldgapplicationValues { get; set; }
        public virtual DbSet<BldgassessorApproval> BldgassessorApproval { get; set; }
        public virtual DbSet<BldgcityApproval> BldgcityApproval { get; set; }
        public virtual DbSet<Bldgcontractors> Bldgcontractors { get; set; }
        public virtual DbSet<BldgdemolitionPermitDetail> BldgdemolitionPermitDetail { get; set; }
        public virtual DbSet<Bldgdepartments> Bldgdepartments { get; set; }
        public virtual DbSet<BldgfeeDistributionCategories> BldgfeeDistributionCategories { get; set; }
        public virtual DbSet<BldgfireDistrictCodes> BldgfireDistrictCodes { get; set; }
        public virtual DbSet<BldggradingExcavatingPermitDetail> BldggradingExcavatingPermitDetail { get; set; }
        public virtual DbSet<BldghealthApproval> BldghealthApproval { get; set; }
        public virtual DbSet<Bldgjurisdictions> Bldgjurisdictions { get; set; }
        public virtual DbSet<BldgmanufactureModularBuildingPermit> BldgmanufactureModularBuildingPermit { get; set; }
        public virtual DbSet<BldgmechanicalPermitDetail> BldgmechanicalPermitDetail { get; set; }
        public virtual DbSet<BldgmobileHomeDealersInstallersArchitects> BldgmobileHomeDealersInstallersArchitects { get; set; }
        public virtual DbSet<BldgotherPermitDetail> BldgotherPermitDetail { get; set; }
        public virtual DbSet<BldgpermitApplicationMaster> BldgpermitApplicationMaster { get; set; }
        public virtual DbSet<BldgpermitCodes> BldgpermitCodes { get; set; }
        public virtual DbSet<BldgpermitsConditionsUserAuthority> BldgpermitsConditionsUserAuthority { get; set; }
        public virtual DbSet<BldgplanningApproval> BldgplanningApproval { get; set; }
        public virtual DbSet<BldgpublicWorksApproval> BldgpublicWorksApproval { get; set; }
        public virtual DbSet<BldgplumbingPermitDetail> BldgplumbingPermitDetail { get; set; }
        public virtual DbSet<BldgstateClassifications> BldgstateClassifications { get; set; }
        public virtual DbSet<BldgstructureBuildingPermitDetail> BldgstructureBuildingPermitDetail { get; set; }
        public virtual DbSet<TreasallPropertyArtreasurerComments> TreasallPropertyArtreasurerComments { get; set; }
        public virtual DbSet<TreasallPropertyMaster> TreasallPropertyMaster { get; set; }
        public virtual DbSet<TreasallPropertyTaxReceivableMaster> TreasallPropertyTaxReceivableMaster { get; set; }
        public virtual DbSet<TreasallPropertyTaxReceivableTransactions> TreasallPropertyTaxReceivableTransactions { get; set; }
        public virtual DbSet<TreaspersonalPropertyMaster> TreaspersonalPropertyMaster { get; set; }
        public virtual DbSet<TreasspecialAssessmentsTaxReceivableMaster> TreasspecialAssessmentsTaxReceivableMaster { get; set; }
        public virtual DbSet<TreasspecialAssessmentsTransactions> TreasspecialAssessmentsTransactions { get; set; }
        public virtual DbSet<TreasPropertyMasterInfoView> TreasPropertyMasterInfoView { get; set; }

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

            modelBuilder.Entity<AsmtcityCodeFile>(entity =>
            {
                entity.ToTable("ASMTCityCodeFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Filler01)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCityCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
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

            modelBuilder.Entity<AsmtinstrumentType>(entity =>
            {
                entity.ToTable("ASMTInstrumentType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account1).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Account2).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Account3).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Account4).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.FeeAccount1).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.FeeAccount2).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.FeeAccount3).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.FeeAccount4).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Filler01)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IndexingException)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InstrumentTypeDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Satisfaction)
                    .HasMaxLength(1)
                    .IsUnicode(false);
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

            modelBuilder.Entity<AsmtlegalDocuments>(entity =>
            {
                entity.ToTable("ASMTLegalDocuments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AffidavitNumber).HasColumnType("numeric(9, 0)");

                entity.Property(e => e.AffidavitNumberExtension)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AssocateParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.AuditorFileNumber).HasColumnType("numeric(11, 0)");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("ChangeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Filler01)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LegalDocumentType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LegalInstrumentDate).HasColumnType("date");

                entity.Property(e => e.Page).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PageExtension)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.PreviousOwnerSeller)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProbateNumber).HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SeqNumber).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Volume).HasColumnType("numeric(4, 0)");
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

            modelBuilder.Entity<AsmtnameChangeHistory>(entity =>
            {
                entity.ToTable("ASMTNameChangeHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

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

                entity.Property(e => e.NameType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsmtnewConstruction>(entity =>
            {
                entity.ToTable("ASMTNewConstruction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("ChangeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Filler)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NewConstructionBuildingAv)
                    .HasColumnName("NewConstructionBuildingAV")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NewConstructionLandAv)
                    .HasColumnName("NewConstructionLandAV")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevaluationPhase)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<AsmtnotesAndComments>(entity =>
            {
                entity.ToTable("ASMTNotesAndComments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Filler)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
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

            modelBuilder.Entity<AsmtparentChildRelationshipsNew>(entity =>
            {
                entity.ToTable("ASMTParentChildRelationshipsNew");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FromParcel).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.LegalDocumentType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipParcel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SegCombDate).HasColumnType("date");

                entity.Property(e => e.ToParcel).HasColumnType("numeric(16, 0)");
            });

            modelBuilder.Entity<AsmtpermitMaster>(entity =>
            {
                entity.ToTable("ASMTPermitMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.CheckedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CheckedYearMonth).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntered).HasColumnType("date");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryProgram)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedValue).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NewOrDemo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.PercentComplete).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PermitAddendum).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PermitCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PermitIssuedDate).HasColumnType("date");

                entity.Property(e => e.PermitNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PermitNumberString)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PermitStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PermitYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
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

            modelBuilder.Entity<AsmtsalesAndExciseTaxData>(entity =>
            {
                entity.ToTable("ASMTSalesAndExciseTaxData");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acres).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.AffidavitNumber).HasColumnType("numeric(9, 0)");

                entity.Property(e => e.AffidavitNumberExtension)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AssessedValue).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Comment)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Filler01)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Filler02)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IncorporatedArea)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LandUseCode).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.LegalDocumentType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MultipleParcelSale)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PPsalesAmount)
                    .HasColumnName("P/PSalesAmount")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.PersPropParcel).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.RPsalesAmount)
                    .HasColumnName("R/PSalesAmount")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RevaluationPhase)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SaleDate).HasColumnType("date");

                entity.Property(e => e.SaleRejectionCode).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.SeqNumber).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TaxCodeArea).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<AsmtsalesRejectionReasonCodes>(entity =>
            {
                entity.ToTable("ASMTSalesRejectionReasonCodes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Filler01)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SaleRejectionCode).HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<AsmtseniorCitizenHistory>(entity =>
            {
                entity.ToTable("ASMTSeniorCitizenHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdjustPriorYearFrozenBuilding).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.AdjustPriorYearFrozenImprovedLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.AdjustPriorYearFrozenTimberLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.AdjustPriorYearFrozenUnimprovedLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeUserId)
                    .HasColumnName("ChangeUserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDateFrozendAv)
                    .HasColumnName("EffectiveDateFrozendAV")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NewConstValueBuilding).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NewConstValueImporvedLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NewConstValueTimberLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NewConstValueUnimporvedLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NonSrCiFmunimpLndValue)
                    .HasColumnName("NonSrCiFMUnimpLndValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NonSrCitCuimpLndValue)
                    .HasColumnName("NonSrCitCUImpLndValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NonSrCitCutimberLndValue)
                    .HasColumnName("NonSrCitCUTimberLndValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NonSrCitCuunimpLndValue)
                    .HasColumnName("NonSrCitCUUnimpLndValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NonSrCitFmbldgValue)
                    .HasColumnName("NonSrCitFMBldgValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NonSrCitFmimpLndValue)
                    .HasColumnName("NonSrCitFMImpLndValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.NonSrCitFmtimberLndValue)
                    .HasColumnName("NonSrCitFMTimberLndValue")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.PriorYearFrozenBuilding).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.PriorYearFrozenImprovedLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.PriorYearFrozenTimberLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.PriorYearFrozenUnimprovedLand).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SeniorCitizenCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SeniorExcessLevyExemptAv)
                    .HasColumnName("SeniorExcessLevyExemptAV")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.SrRegularLeveyExcemptAv)
                    .HasColumnName("SrRegularLeveyExcemptAV")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.SrRegularLeveyExcemptOr)
                    .HasColumnName("SrRegularLeveyExcemptOR")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TotalAvbeforeSrExempt)
                    .HasColumnName("TotalAVBeforeSrExempt")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.TotalFrozenValueTaxYear).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.TotalMarketValue).HasColumnType("decimal(9, 0)");
            });

            modelBuilder.Entity<AsmtsenirCitizenExemptionRate>(entity =>
            {
                entity.ToTable("ASMTSenirCitizenExemptionRate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExcLevyExemptPercent).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaximumIncome).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegLevyExemptPercent).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.RegLevyMaxExemptAv)
                    .HasColumnName("RegLevyMaxExemptAV")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.RegLevyMinExemptAv)
                    .HasColumnName("RegLevyMinExemptAV")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.SeniorCitizenCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<AsmtsitusAddress>(entity =>
            {
                entity.ToTable("ASMTSitusAddress");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Filler01)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HouseNumber).HasColumnType("numeric(8, 0)");

                entity.Property(e => e.HouseNumberExtension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StreetDirectionQuadrant)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(20)
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

            modelBuilder.Entity<BldgapplcationReceiptDetail>(entity =>
            {
                entity.ToTable("BLDGApplcationReceiptDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeTime).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FeeDistributionCategory).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgapplcationReceiptHeader>(entity =>
            {
                entity.ToTable("BLDGApplcationReceiptHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CashAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ChangeAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeTime).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CheckAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.PaidByCheckNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptComment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptDate).HasColumnType("date");

                entity.Property(e => e.ReceiptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ReceiptType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgapplicationConditions>(entity =>
            {
                entity.ToTable("BLDGApplicationConditions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ConditionDepartmentCode)
                    .HasColumnName("ConditionDepartment Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionLine1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionLine2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionLine3)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionLine4)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionLine5)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionLine6)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionSequence).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DateRemoved).HasColumnType("date");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredByUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("date");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonRemoved)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemoveAuthorizedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RemoveAuthorizedDate).HasColumnType("date");

                entity.Property(e => e.RemovedByUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgapplicationFees>(entity =>
            {
                entity.ToTable("BLDGApplicationFees");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.BaseFee).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.ChargeByValue)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ExtendedAmount).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.FeeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FeeDescription)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FeeDistributionCategory).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FeeIncrement).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MinMaxFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfUnits).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SequenceNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.UnitCharge).HasColumnType("numeric(7, 2)");
            });

            modelBuilder.Entity<BldgapplicationInspections>(entity =>
            {
                entity.ToTable("BLDGApplicationInspections");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.DateInspectionEntered).HasColumnType("date");

                entity.Property(e => e.DateRemoved).HasColumnType("date");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EnteredByUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("date");

                entity.Property(e => e.InspectedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionDate).HasColumnType("date");

                entity.Property(e => e.InspectionDepartmentCode)
                    .HasColumnName("InspectionDepartment Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionEnteredByUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionLine1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionLine2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionLine3)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionLine4)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionLine5)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionLine6)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonRemoved)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RemoveAuthorizedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RemoveAuthorizedDate).HasColumnType("date");

                entity.Property(e => e.RemovedByUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SequenceNumber).HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<BldgapplicationNotes>(entity =>
            {
                entity.ToTable("BLDGApplicationNotes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SequenceNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgapplicationValues>(entity =>
            {
                entity.ToTable("BLDGApplicationValues");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ComponentDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ConstructionTypeDescription)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ConstructionTypeShortDescription)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ExtendedValue).HasColumnType("numeric(11, 2)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfOccupants).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.OccupantType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SectionDescription)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SequenceNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.SquareFeet).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.TableNumberSectLineSeq).HasColumnType("numeric(6, 0)");
            });

            modelBuilder.Entity<BldgassessorApproval>(entity =>
            {
                entity.ToTable("BLDGAssessorApproval");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedByAssr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeDateAssr).HasColumnType("date");

                entity.Property(e => e.CheckedYearMonth).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PercentComplete).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserIdassr)
                    .HasColumnName("UserIDAssr")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgcityApproval>(entity =>
            {
                entity.ToTable("BLDGCityApproval");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.CityCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UtilitiesApproval)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZoningApproval)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bldgcontractors>(entity =>
            {
                entity.ToTable("BLDGContractors");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContractLicenseNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorBusinessName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorSearchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastChanged).HasColumnType("date");

                entity.Property(e => e.FaxNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.InternetAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MailingAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtensionNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PhoneNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PhoneNumber2).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RecordStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgdemolitionPermitDetail>(entity =>
            {
                entity.ToTable("BLDGDemolitionPermitDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.BldgDeptApprovalBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptDateApproved).HasColumnType("date");

                entity.Property(e => e.BldgDeptSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.BuildingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateProvided).HasColumnType("date");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Dimensions)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FireDistrictCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovalBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.FireMarshalApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalDateApproved).HasColumnType("date");

                entity.Property(e => e.FireMarshalSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeProjectDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredHandoutsProvided)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SquareFeet).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.ToWhomProvided)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<AsmtsenirCitizenExemptionRate>(entity =>
            {
                entity.ToTable("ASMTSenirCitizenExemptionRate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExcLevyExemptPercent).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaximumIncome).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RegLevyExemptPercent).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.RegLevyMaxExemptAv)
                    .HasColumnName("RegLevyMaxExemptAV")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.RegLevyMinExemptAv)
                    .HasColumnName("RegLevyMinExemptAV")
                    .HasColumnType("decimal(9, 0)");

                entity.Property(e => e.SeniorCitizenCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<AsmtsitusAddress>(entity =>
            {
                entity.ToTable("ASMTSitusAddress");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Filler01)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HouseNumber).HasColumnType("numeric(8, 0)");

                entity.Property(e => e.HouseNumberExtension)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StreetDirectionQuadrant)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(20)
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

            modelBuilder.Entity<Bldgdepartments>(entity =>
            {
                entity.ToTable("BLDGDepartments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LongDepartmentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDepartmentName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgfeeDistributionCategories>(entity =>
            {
                entity.ToTable("BLDGFeeDistributionCategories");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.FeeDistributionCategory).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FeeDistributionDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDisplayDescription)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgfireDistrictCodes>(entity =>
            {
                entity.ToTable("BLDGFireDistrictCodes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.FireDistrictCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LongFireDistrictName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShortFireDistrictName)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldggradingExcavatingPermitDetail>(entity =>
            {
                entity.ToTable("BLDGGradingExcavatingPermitDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AdditionalFireFlowRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AmountOfFireFlowRequired)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.BldgDeptApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptDateApproved).HasColumnType("date");

                entity.Property(e => e.BldgDeptSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CubicYardsOfFill).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DustAndTrackControlReceived)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DustAndTrackReceivedDate).HasColumnType("date");

                entity.Property(e => e.EngineeringReceived)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EngineeringReceivedDate).HasColumnType("date");

                entity.Property(e => e.FireDistrictCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireFlowAlreadyProvided)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.FireMarshalApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalDateApproved).HasColumnType("date");

                entity.Property(e => e.FireMarshalSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeProjectDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PercentOfSlope).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SoilErosionControlRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldghealthApproval>(entity =>
            {
                entity.ToTable("BLDGHealthApproval");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bldgjurisdictions>(entity =>
            {
                entity.ToTable("BLDGJurisdictions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LongDepartmentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDepartmentName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Bldgjurisdictions>(entity =>
            {
                entity.ToTable("BLDGJurisdictions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LongDepartmentName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDepartmentName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<BldgmanufactureModularBuildingPermit>(entity =>
            {
                entity.ToTable("BLDGManufactureModularBuildingPermit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AdditionalFireFlowRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AmountOfFireFlowRequired)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ApproxDeliveryDate).HasColumnType("date");

                entity.Property(e => e.ApproxPurchaseDate).HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptDateApproved).HasColumnType("date");

                entity.Property(e => e.BldgDeptSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.BuildingDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CertInstallerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CommercialUseDesc1)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CommercialUseDesc2)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CountyStateIfNotGrant)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DealerNameCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Dimensions)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FireDistrictCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireFlowAlreadyProvided)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.FireMarshalApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalDateApproved).HasColumnType("date");

                entity.Property(e => e.FireMarshalSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.InstallationIncludedInPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LotorMan)
                    .HasColumnName("LOTorMAN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ManorMod)
                    .HasColumnName("MANorMOD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MovingFromAddress)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.MovingFromGrantCounty)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MovingFromParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.NewOrUsed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeProjectDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResCommStor)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SquareFeet).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.TaxpayerName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOwnerName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.YearManufactured).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<BldgmechanicalPermitDetail>(entity =>
            {
                entity.ToTable("BLDGMechanicalPermitDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.BldgDeptApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptDateApproved).HasColumnType("date");

                entity.Property(e => e.BldgDeptSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireDistrictCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.FireMarshalApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalDateApproved).HasColumnType("date");

                entity.Property(e => e.FireMarshalSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nrecreceived)
                    .HasColumnName("NRECReceived")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeProjectDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgmobileHomeDealersInstallersArchitects>(entity =>
            {
                entity.ToTable("BLDGMobileHomeDealersInstallersArchitects");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Architects)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessSearchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CertifiedInstaller)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastChanged).HasColumnType("date");

                entity.Property(e => e.Engineers)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.InternetAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseExpireDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MobileHomeDealer)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OtherCode1)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OtherCode2)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OtherCode3)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtensionNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PhoneNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PhoneNumber2).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgotherPermitDetail>(entity =>
            {
                entity.ToTable("BLDGOtherPermitDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AdditionalFireFlowRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalInformationDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.AmountOffireFlowRequired)
                    .HasColumnName("AmountOFFireFlowRequired")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.BldgDeptApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptDateApproved).HasColumnType("date");

                entity.Property(e => e.BldgDeptSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireDistrictCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireFlowAlreadyProvided)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.FireMarshalApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalDateApproved).HasColumnType("date");

                entity.Property(e => e.FireMarshalSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeProjectDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgpermitApplicationMaster>(entity =>
            {
                entity.ToTable("BLDGPermitApplicationMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualExpireDate).HasColumnType("date");

                entity.Property(e => e.ActualExpireTime).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AdditionalInformation)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantBusinessName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantLastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantProjectDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationAccepted)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationAcceptedDate).HasColumnType("date");

                entity.Property(e => e.ApplicationAcceptedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationDate).HasColumnType("date");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ArchitectApprovalDate).HasColumnType("date");

                entity.Property(e => e.ArchitectApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArchitectApprovalUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArchitectFirmNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AssessorApprovalDate).HasColumnType("date");

                entity.Property(e => e.AssessorApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AssessorApprovalUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AssessorParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.AssignedFee).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AssignedValue).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.BuildingApprovalDate).HasColumnType("date");

                entity.Property(e => e.BuildingApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingApprovalUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CityJurisdictionApprovalDate).HasColumnType("date");

                entity.Property(e => e.CityJurisdictionApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CityJurisdictionApprovalUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityUtilityApprovalDate).HasColumnType("date");

                entity.Property(e => e.CityUtilityApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CityUtilityApprovalUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClassCodeExtension)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContractLicenseNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.EnforcementDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.EngineerFirmNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredByUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FinalDate).HasColumnType("date");

                entity.Property(e => e.FinalTime).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.FinaledByUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FireApprovalRequiredDate).HasColumnType("date");

                entity.Property(e => e.FireApprovalRequiredUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovalDate).HasColumnType("date");

                entity.Property(e => e.FireMarshalApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovalUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HealthApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HealthApprovalRequiredDate).HasColumnType("date");

                entity.Property(e => e.HealthApprovalRequiredUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LIapprovalRequired)
                    .HasColumnName("L&IApprovalRequired")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LIapprovalRequiredDate)
                    .HasColumnName("L&IApprovalRequiredDate")
                    .HasColumnType("date");

                entity.Property(e => e.LIapprovalRequiredUser)
                    .HasColumnName("L&IApprovalRequiredUser")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnlyResidenceOnParcel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OnlyStructureOnParcel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OtherSpecialApprovalDescription)
                    .HasColumnName("OtherSpecialApproval Description")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OtherSpecialApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OtherSpecialApprovalRequiredDate).HasColumnType("date");

                entity.Property(e => e.OtherSpecialApprovalRequiredUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerApprovalRequiredDate).HasColumnType("date");

                entity.Property(e => e.OwnerApprovalRequiredUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ParkInformation)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PermitCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PermitIssuedDate).HasColumnType("date");

                entity.Property(e => e.PermitIssuedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PermitNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PermitStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PermitYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PhoneNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PlanningApprovalDate).HasColumnType("date");

                entity.Property(e => e.PlanningApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PlanningApprovalUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlotPlanReceived)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PreliminaryParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.ProcessedForJurisdiction)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectInformation)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectedExpireDate).HasColumnType("date");

                entity.Property(e => e.PublicWroksApprovalDate).HasColumnType("date");

                entity.Property(e => e.PublicWroksApprovalRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PublicWroksApprovalUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResultOfEnforcementAction)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SiteAddress)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StateClassCode).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.VoidDate).HasColumnType("date");

                entity.Property(e => e.VoidTime).HasColumnType("numeric(6, 0)");

                entity.Property(e => e.VoidedByUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgpermitCodes>(entity =>
            {
                entity.ToTable("BLDGPermitCodes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.PermitCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PermitDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PermitSearchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShortPermitName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgpermitsConditionsUserAuthority>(entity =>
            {
                entity.ToTable("BLDGPermitsConditionsUserAuthority");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignAssessorParcel)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToAddChangeApps)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToAddConditions)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToAddFees)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToAddInspection)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToAddPermitDetail)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToAddValuations)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToApproveApps)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToChangeAppsStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToChangePrmtStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToIssuePermit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToIssueReceipt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToRemoveConditions)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToRemoveInspection)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorityToUpdateNotes)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeUserId)
                    .HasColumnName("ChangeUserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomeDepartment)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PermitDepartment)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentAssessors)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentBuildingDepartment)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentCityDepartment)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentFireDepartment)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentHealthDepartment)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentPlanningDepartment)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentPublicWorksDepartment)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserJob)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValidUserId)
                    .HasColumnName("ValidUserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgplanningApproval>(entity =>
            {
                entity.ToTable("BLDGPlanningApproval");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BackPropertySetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FloodZone)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FloodZoneMapNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FrontPropertySetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LUpermitRequired)
                    .HasColumnName("L/UPermitRequired")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SideFlankingSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.SidePropertySetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<BldgplumbingPermitDetail>(entity =>
            {
                entity.ToTable("BLDGPlumbingPermitDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.BldgDeptApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptDateApproved).HasColumnType("date");

                entity.Property(e => e.BldgDeptSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireDistrictCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.FireMarshalApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalDateApproved).HasColumnType("date");

                entity.Property(e => e.FireMarshalSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeProjectDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgpublicWorksApproval>(entity =>
            {
                entity.ToTable("BLDGPublicWorksApproval");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BldgstateClassifications>(entity =>
            {
                entity.ToTable("BLDGStateClassifications");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ClassCodeExtension)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClassificationDescription)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateClassCode).HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<BldgstructureBuildingPermitDetail>(entity =>
            {
                entity.ToTable("BLDGStructureBuildingPermitDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddendumNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AdditionalFireFlowRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmSystemDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmSystemRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AmountOfFireFlowRequired)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationNumber).HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ApplicationYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.BldgDepDateApproved)
                    .HasColumnName("BldgDep DateApproved")
                    .HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.BldgDeptApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BldgDeptSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("Department Code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireDistrictCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FireFlowAlreadyProvided)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalApprovedChangeDate).HasColumnType("date");

                entity.Property(e => e.FireMarshalApprovedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FireMarshalDateApproved).HasColumnType("date");

                entity.Property(e => e.FireMarshalSetback).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.HeatSourceDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Heated)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nrecreceived)
                    .HasColumnName("NRECReceived")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfBathrooms).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumberOfBedrooms).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumberOfUnits).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OfficeProjectDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PermitIncludeMechanical)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PermitIncludePlumbing)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PlansAnalystReviewDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlansAnalystReviewDone)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrescriptiveReviewDone)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResAgCommOther)
                    .HasColumnName("Res,AgCommOther")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInspectionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInspectionRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SprinklerSystemDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SprinklerSystemRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WattsunRunReviewDone)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreasallPropertyArtreasurerComments>(entity =>
            {
                entity.ToTable("TREASAllPropertyARTreasurerComments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeUserId)
                    .HasColumnName("ChangeUserID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CommentLine1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CommentLine2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Filler01)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Filler02)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PPparcelNumber)
                    .HasColumnName("P/PParcelNumber")
                    .HasColumnType("numeric(7, 0)");

                entity.Property(e => e.PPprcExt)
                    .HasColumnName("P/PPrcExt")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ParcelExtension).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreasallPropertyMaster>(entity =>
            {
                entity.ToTable("TREASAllPropertyMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LandUseCode).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.ParentParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCodeArea).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxpayerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOwnerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreasallPropertyTaxReceivableMaster>(entity =>
            {
                entity.ToTable("TREASAllPropertyTaxReceivableMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssessedValue).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.FilingPenalty).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Filler)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Fpamount)
                    .HasColumnName("FPAmount")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FpfeeAmount)
                    .HasColumnName("FPFeeAmount")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.FpfeePaid)
                    .HasColumnName("FPFeePaid")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Fppaid)
                    .HasColumnName("FPPaid")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Fpsupplement)
                    .HasColumnName("FPSupplement")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.InterestPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LienIndicators)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lpamount)
                    .HasColumnName("LPAmount")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Lppaid)
                    .HasColumnName("LPPaid")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.NetSupplementsLessCancels).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ParcelExtension).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RecCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialAssessments).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.SrCitCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxpayerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UseCode).HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<TreasallPropertyTaxReceivableTransactions>(entity =>
            {
                entity.ToTable("TREASAllPropertyTaxReceivableTransactions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeUserId)
                    .HasColumnName("ChangeUserID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedAssessedValue).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.ChgReasonCd)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FPamount)
                    .HasColumnName("F/PAmount")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Filler01)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Filler02)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FpfeeAmount)
                    .HasColumnName("FPFeeAmount")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.InterestPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.LPamount)
                    .HasColumnName("L/PAmount")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ParcelExtension).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.RcptExt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptTranNumber).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.SrCitCd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TranDate).HasColumnType("date");

                entity.Property(e => e.TranTypeCd)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreaspersonalPropertyMaster>(entity =>
            {
                entity.ToTable("TREASPersonalPropertyMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abs10Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs11Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs12Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs13Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs14Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs1Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs2Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs3Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs4Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs5Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs6Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs7Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs8Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.Abs9Value).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.ChangeReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChgId)
                    .HasColumnName("ChgID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExemptRegNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Filler01)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Filler02)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Filler03)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Filler04)
                    .HasMaxLength(66)
                    .IsUnicode(false);

                entity.Property(e => e.FormReturnDate).HasColumnType("date");

                entity.Property(e => e.FormStatCd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeadofHouseholdExemption)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LandUseCode).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.LienCertNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LienDate).HasColumnType("date");

                entity.Property(e => e.Location)
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

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.PenPercent).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PersPropParcel).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.RecType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SeniorCitizenCd)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateOfIncorporation)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCodeArea).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxpayerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TitleOwnerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreasspecialAssessmentsTaxReceivableMaster>(entity =>
            {
                entity.ToTable("TREASSpecialAssessmentsTaxReceivableMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssessmentAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AssessmentPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AssessmentSupplement).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BasisAmount1Units).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.BasisAmount2).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BasisAmount3).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BasisAmount4).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BasisAmount5).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BillWRPflag)
                    .HasColumnName("BillW/R/Pflag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictClass).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DistrictSequenceNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DueDateCymmdd)
                    .HasColumnName("DueDateCYMMDD")
                    .HasColumnType("date");

                entity.Property(e => e.FeeAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FeePaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FeeSupplement).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Filler)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.InterestPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.PenaltyAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.PenaltyPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TaxpayerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreasspecialAssessmentsTransactions>(entity =>
            {
                entity.ToTable("TREASSpecialAssessmentsTransactions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssessmentPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ChangeBasisAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("ChangeID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DistrictClass).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DistrictSequenceNumber).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FeePaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Filler01)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InterestPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ParcelNumber).HasColumnType("numeric(16, 0)");

                entity.Property(e => e.PenaltyPaid).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ReceiptExtension)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptTransactionNumber).HasColumnType("numeric(7, 0)");

                entity.Property(e => e.RecordCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TranactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });
        }
    }
}
