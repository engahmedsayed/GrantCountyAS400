using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class PersonnelMapper
    {
        internal static Personnel Map(AcctPersonnel personnel) =>
            new Personnel(personnel.Id, personnel.Name, personnel.Ssnumber.Value, personnel.PersonNumber.Value);
    }
}