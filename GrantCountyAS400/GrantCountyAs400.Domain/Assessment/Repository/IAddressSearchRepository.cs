using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IAddressSearchRepository
    {
        IEnumerable<AddressSearch> GetAll(decimal parcelNumber,decimal houseNumber,string streetName,
                                        out int resultCount, int pageNumber = 1, int pageSize = 50);
    }
}
