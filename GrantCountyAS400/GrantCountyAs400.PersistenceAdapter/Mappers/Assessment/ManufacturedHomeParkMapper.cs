using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers.Assessment
{
    internal static class ManufacturedHomeParkMapper
    {
        internal static ManufacturedHomePark Map(AsmtmobileHomeParks homepark, AsmtmasterNameAddress nameAddress) =>
            new ManufacturedHomePark(homepark.Id, homepark.MhparkCode, homepark.Name.Trim(), homepark.AddressLine1.Trim(), homepark.AddressLine2.Trim(),
                homepark.ContactNameCode, nameAddress?.Name.Trim(), homepark.TelephoneNumber, homepark.ParcelNumber.Value);

        internal static ManufacturedHomeParkDetails Map(AsmtmobileHomeParks homepark, AsmtmasterNameAddress nameAddress,
                                                        AsmtrealPropertyAssessedValueMaster masterRecord) =>
            new ManufacturedHomeParkDetails(homepark.MhparkCode, homepark.Name.Trim(), homepark.AddressLine1.Trim(), homepark.AddressLine2.Trim(),
                homepark.ContactNameCode, nameAddress?.Name.Trim(), homepark.TelephoneNumber, homepark.ParcelNumber.Value, homepark.Filler01,
                homepark.SpaceNumber.Value, homepark.QualCode.Trim(), masterRecord?.Description1, masterRecord?.Description2, masterRecord?.Description3,
                masterRecord?.Description4, masterRecord?.Description5);
    }
}