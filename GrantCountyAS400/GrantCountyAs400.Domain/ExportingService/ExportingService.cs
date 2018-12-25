using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.Domain.Enums;
using OfficeOpenXml;

namespace GrantCountyAs400.Domain.ExportingService
{
    public class ExportingService : IExportingService
    {

        private readonly IBuildingPermitSystemRepository _buildingPermitRepo;
        private readonly IAccountPayableRepository _accountPayableRepository;
        private readonly IAccountPayrollRepository _accountPayrollRepository;

        public ExportingService(IBuildingPermitSystemRepository buildingPermitSystemRepository, IAccountPayableRepository accountPayableRepository,IAccountPayrollRepository accountPayrollRepository)
        {
            _buildingPermitRepo = buildingPermitSystemRepository;
            _accountPayableRepository = accountPayableRepository;
            _accountPayrollRepository = accountPayrollRepository;
        }

        public MemoryStream GetAccountPayroll(string firstName, string lastName, decimal sSN, DateTime? minDate, DateTime? maxDate, decimal employeeNumber, out int resultCount, int pageNumber, int pageSize)
        {
            string excelTemplate = GetExcelTemplate(ReportType.AccountPayroll);
            var templateFile = new FileInfo(excelTemplate);
            ExcelPackage package = new ExcelPackage(templateFile, true);
            GenerateAccountPayrollReportExcel(package, _accountPayrollRepository
                    .GetAll(firstName, lastName, sSN, minDate, maxDate, employeeNumber, out resultCount, pageNumber,
                            pageSize).ToList());

            var stream = new MemoryStream(package.GetAsByteArray());
            return stream;
        }

       

        public MemoryStream GetAccountsPayable(string vendorId, string name, string representative, DateTime? minPayDate, DateTime? maxPayDate, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            string excelTemplate = GetExcelTemplate(ReportType.AccountPayable);
            var templateFile = new FileInfo(excelTemplate);
            ExcelPackage package = new ExcelPackage(templateFile, true);

            GenerateAccountPayableReportExcel(package, _accountPayableRepository.GetAll(
                vendorId,name,representative,minPayDate,maxPayDate,out resultCount,pageNumber,pageSize).ToList());

            var stream = new MemoryStream(package.GetAsByteArray());
            return stream;

        }

        public MemoryStream GetBuildingPermitSystem(BuildingSearchCriteria filter)
        {
            string excelTemplate = GetExcelTemplate(ReportType.BuildingPermitType);
            var templateFile = new FileInfo(excelTemplate);
            ExcelPackage package = new ExcelPackage(templateFile, true);
            var results = _buildingPermitRepo.GetAll(
                filter,
                out int resultCount,
                -1,
                50);
            GenerateBuildingModuleReportExcel(package,results);

            var stream = new MemoryStream(package.GetAsByteArray());
            return stream;
        }

        private void GenerateAccountPayableReportExcel(ExcelPackage excelPackage,List<VenderWarrent> reportData)
        {
            var dataSheet = excelPackage.Workbook.Worksheets[0];
            var sheetStartingIndex = 2;
            var rowIndex = sheetStartingIndex;
            foreach (var item in reportData)
            {

                dataSheet.Cells["A" + rowIndex].Value = item.Name;
                dataSheet.Cells["B" + rowIndex].Value = item.Vendor;
                dataSheet.Cells["C" + rowIndex].Value = item.WarrantNumber;
                dataSheet.Cells["D" + rowIndex].Value = item.CheckNumber;
                dataSheet.Cells["E" + rowIndex].Value = item.WarrantDate;
                dataSheet.Cells["F" + rowIndex].Value = item.PayDate;
                dataSheet.Cells["G" + rowIndex].Value = item.Status;
                dataSheet.Cells["H" + rowIndex].Value = item.Ponumber;
                dataSheet.Cells["I" + rowIndex].Value = $"{item.Fund?.Trim()}-{item.Department?.Trim()}-{item.Program?.Trim()}-{item.Project?.Trim()}-{item.Base?.Trim()}";
                dataSheet.Cells["J" + rowIndex].Value = item.Amount;


                rowIndex++;
            }

            dataSheet.Cells.AutoFitColumns();
            dataSheet.View.TabSelected = false;
        }

        private void GenerateAccountPayrollReportExcel(ExcelPackage excelPackage, List<AccountPayroll> reportData)
        {
            var dataSheet = excelPackage.Workbook.Worksheets[0];
            var sheetStartingIndex =2;
            var rowIndex = sheetStartingIndex;
            var rowDetailIndex = 2;
            foreach (var item in reportData.Distinct())
            {
                var detailSheet = excelPackage.Workbook.Worksheets.Add(item.Name.ToString().Trim()+"-"+item.Id.ToString(), excelPackage.Workbook.Worksheets["Detail"]);
                rowDetailIndex = 2;
                if (item.PayrollWarrants.Any())
                {
                    foreach (var detailItem in item.PayrollWarrants)
                    {
                        detailSheet.Cells[$"A{rowDetailIndex}:I{rowDetailIndex}"].Style.Font.Bold = true;
                        detailSheet.Cells["A" + rowDetailIndex].Value = detailItem.WarrantNumber;
                        detailSheet.Cells["B" + rowDetailIndex].Value = detailItem.CheckNumber;
                        detailSheet.Cells["C" + rowDetailIndex].Value = detailItem.Date;
                        detailSheet.Cells["D" + rowDetailIndex].Value = detailItem.Gross;
                        detailSheet.Cells["E" + rowDetailIndex].Value = detailItem.Fica;
                        detailSheet.Cells["F" + rowDetailIndex].Value = detailItem.Medical;
                        detailSheet.Cells["G" + rowDetailIndex].Value = detailItem.RetirementPay;
                        detailSheet.Cells["H" + rowDetailIndex].Value = detailItem.RetirementBenefitsEmployer;
                        detailSheet.Cells["I" + rowDetailIndex].Value = detailItem.NetPay;
                        detailSheet.Cells.AutoFitColumns();
                        detailSheet.View.TabSelected = false;
                        rowDetailIndex++;
                    }
                    

                }
                dataSheet.Cells["A" + rowIndex].Value = item.Name;
                dataSheet.Cells["B" + rowIndex].Value = item.PersonNumber;
                dataSheet.Cells["C" + rowIndex].Value = item.SSNumber;
                rowIndex++;
            }
            dataSheet.Cells.AutoFitColumns();
            dataSheet.View.TabSelected = false;
            excelPackage.Workbook.Worksheets.Delete("Detail");
        }

        private void GenerateBuildingModuleReportExcel(ExcelPackage excelPackage, List<BuildingPermitSystem> reportData)
        {
            var dataSheet = excelPackage.Workbook.Worksheets[0];
            var sheetStartingIndex = 2;
            var rowIndex = sheetStartingIndex; // starting index of each sheet.
            foreach (var item in reportData)
            {
                
                dataSheet.Cells["A" + rowIndex].Value = item.ApplicationDate;
                dataSheet.Cells["A" + rowIndex].Style.Numberformat.Format = "mm/d/yyyy";
                dataSheet.Cells["B" + rowIndex].Value = item.PermitIssueDate;
                dataSheet.Cells["B" + rowIndex].Style.Numberformat.Format = "mm/d/yyyy";
                dataSheet.Cells["C" + rowIndex].Value = item.AssessorParcelNumber;
                dataSheet.Cells["D" + rowIndex].Value = item.ApplicationYear + (item.ApplicationNumber.HasValue ? "-" + item.ApplicationNumber : "");
                dataSheet.Cells["E" + rowIndex].Value = item.PermitCode;
                dataSheet.Cells["F" + rowIndex].Value = item.PermitStatus;
                dataSheet.Cells["G" + rowIndex].Value = (item.PermitYear.HasValue && item.PermitYear.Value != 0 ? item.PermitYear.Value.ToString() : "") + "-" + (item.PermitNumber.HasValue && item.PermitNumber.Value != 0 ? item.PermitNumber.Value.ToString() : "");
                dataSheet.Cells["H" + rowIndex].Value = item.ApplicantBusinessName;
                dataSheet.Cells["I" + rowIndex].Value = item.ApplicationName;
                dataSheet.Cells["J" + rowIndex].Value = item.OfficeProjectDescription;
                dataSheet.Cells["K" + rowIndex].Value = item.ContractorBusinessName;

                rowIndex++;
            }

            dataSheet.Cells.AutoFitColumns();
            dataSheet.View.TabSelected = false;
        }

        private string GetExcelTemplate(ReportType type)
        {
            string templatePath = String.Empty;

            switch (type)
            {
                case ReportType.BuildingPermitType:
                    templatePath = System.AppDomain.CurrentDomain.BaseDirectory + "wwwroot\\ExcelTemplates\\BuildingModuleTemplate.xlsx";
                    break;

                case ReportType.AccountPayable:
                    templatePath = System.AppDomain.CurrentDomain.BaseDirectory + "wwwroot\\ExcelTemplates\\AccountPayableTemplate.xlsx";
                    break;
                case ReportType.AccountPayroll:
                    templatePath = System.AppDomain.CurrentDomain.BaseDirectory + "wwwroot\\ExcelTemplates\\AccountPayrollTemplate.xlsx";
                    break;

                default:
                    templatePath = String.Empty;
                    break;
            }

            return templatePath;
        }
    }
}
