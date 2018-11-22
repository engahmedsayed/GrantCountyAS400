using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class VenderWarrentMapper
    {
        internal static VenderWarrent Map(AcctApWarrant warrant, AcctVendor vendor)
            => new VenderWarrent(warrant.Id, warrant.Vendor, warrant.WarrantNumber, warrant.CheckNumber, warrant.WarrantDate, warrant.Status, warrant.Ponumber,
                warrant.Fund, warrant.Department, warrant.Program, warrant.Project, warrant.Base, warrant.Invoice, warrant.Description, warrant.FillType,
                warrant.FiscalYear, warrant.Amount, warrant.PayDate, warrant.Combine, warrant.InvoiceDate, vendor.Name);
    }
}