using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class AssociatedPersonMapper
    {
        internal static AssociatedPersonMain Map(AsmtrealPropertyAssociatedPersons rPASC) =>
            new AssociatedPersonMain(rPASC?.ParcelNumber, rPASC?.NameCode, rPASC?.Comment);

        internal static LineValue Map(AsmtrealPropertyAssociatedPersons rPASC,AsmtmasterNameAddress nName) =>
          new LineValue(rPASC?.NameCode, nName?.NameCode, rPASC?.Comment);

    }
}
