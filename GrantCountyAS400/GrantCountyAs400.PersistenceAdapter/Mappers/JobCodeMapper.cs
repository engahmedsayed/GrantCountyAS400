using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class JobCodeMapper
    {
        internal static JobCode Map(AcctPayrollJobCodes record) =>
            new JobCode(record.Id, record.JobTitle, record.JobCode);
    }
}