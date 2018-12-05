using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.Domain.Enums;
using OfficeOpenXml;

namespace GrantCountyAs400.Domain.ExportingService
{
    public class ExportingService : IExportingService
    {

        private readonly IBuildingPermitSystemRepository _buildingPermitRepo;

        public ExportingService(IBuildingPermitSystemRepository buildingPermitSystemRepository)
        {
            _buildingPermitRepo = buildingPermitSystemRepository;
        }
        public MemoryStream GetBuildingPermitSystem(BuildingSearchCriteria filter)
        {
            string excelTemplate = GetExcelTemplate(ReportType.BuildingPermitType);
            var templateFile = new FileInfo(excelTemplate);
            ExcelPackage package = new ExcelPackage(templateFile, true);

            GenerateDailyDetailReportExcel(package, _buildingPermitRepo.GetAll(
                filter,
                out int resultCount,
                -1,
                50).ToList());

            var stream = new MemoryStream(package.GetAsByteArray());
            return stream;
        }

        private void GenerateDailyDetailReportExcel(ExcelPackage excelPackage, List<BuildingPermitSystem> reportData)
        {
            var dataSheet = excelPackage.Workbook.Worksheets[0];
            var sheetStartingIndex = 2;
            var rowIndex = sheetStartingIndex; // starting index of each sheet.
            foreach (var item in reportData)
            {
                
                dataSheet.Cells["A" + rowIndex].Value = item.ApplicationDate;
                dataSheet.Cells["B" + rowIndex].Value = item.ApplicationNumber;
                dataSheet.Cells["C" + rowIndex].Value = item.PermitCode;
                dataSheet.Cells["D" + rowIndex].Value = item.PermitStatus;
                dataSheet.Cells["E" + rowIndex].Value = item.ApplicationYear;
                dataSheet.Cells["F" + rowIndex].Value = item.PermitNumber;
                dataSheet.Cells["G" + rowIndex].Value = item.ApplicantBusinessName;
                dataSheet.Cells["H" + rowIndex].Value = item.ApplicationName;
                dataSheet.Cells["I" + rowIndex].Value = item.ProjectDescription;
                dataSheet.Cells["J" + rowIndex].Value = item.OfficeProjectDescription;
                dataSheet.Cells["K" + rowIndex].Value = item.ContractorBusinessName;
                dataSheet.Cells["L" + rowIndex].Value = item.ResultOfEnforcementAction;
                dataSheet.Cells["M" + rowIndex].Value = item.CityJurisdictionApprovalRequired;
                dataSheet.Cells["N" + rowIndex].Value = item.CityUtilityApprovalRequired;

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
                    templatePath = System.AppDomain.CurrentDomain.BaseDirectory + "wwwroot\\ExcelTemplates\\BeginingBalancesTemplate.xlsx";
                    break;



                default:
                    templatePath = String.Empty;
                    break;
            }

            return templatePath;
        }
    }
}
