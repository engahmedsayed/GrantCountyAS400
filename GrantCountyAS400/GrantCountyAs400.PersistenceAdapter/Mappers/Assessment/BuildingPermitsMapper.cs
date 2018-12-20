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

        internal static BuildingPermits Map(AsmtrealPropertyAssessedValueMaster rPAV, 
                                            AsmtmasterNameAddress nNAME, AsmtlandUseCodes Lu,List<BuildingPermitsLineValue> lineValues) =>
            new BuildingPermits(rPAV.ParcelNumber, nNAME.Name, nNAME.Name, rPAV.Description1, Lu.UseCodeDesc, rPAV.Description2
                                , rPAV.ImprovedLandAcers + rPAV.UnimprovedLandAcres, rPAV.Description3, rPAV.ImprovedLandValue, rPAV.Description4
                                , rPAV.BuildingValue,lineValues);

        
    }
}
