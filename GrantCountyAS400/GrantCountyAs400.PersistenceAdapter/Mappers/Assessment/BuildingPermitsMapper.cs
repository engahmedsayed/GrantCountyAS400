using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class BuildingPermitsMapper
    {
        internal static BuildingPermitsMain Map(AsmtrealPropertyAssessedValueMaster rPAV, AsmtmasterNameAddress nNAME) =>
            new BuildingPermitsMain(rPAV.ParcelNumber, rPAV.TitleOwnerCode, nNAME.Name);
        
    }
}
