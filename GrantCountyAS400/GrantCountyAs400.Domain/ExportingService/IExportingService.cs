using GrantCountyAs400.Domain.Building;
using System;
using System.IO;

namespace GrantCountyAs400.Domain.ExportingService
{
    public interface IExportingService
    {
        MemoryStream GetBuildingPermitSystem(BuildingSearchCriteria filter);

        MemoryStream GetAccountsPayable(
            string vendorId, string name, string representative, DateTime? minPayDate, DateTime? maxPayDate, out int resultCount, int pageNumber = 1, int pageSize = 50);

        MemoryStream GetAccountPayroll(
            string firstName, string lastName, decimal sSN, DateTime? minDate, DateTime? maxDate, decimal employeeNumber, out int resultCount, int pageNumber = 1, int pageSize = 50);
    }
}