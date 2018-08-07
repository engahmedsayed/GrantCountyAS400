using System;
using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IChildParentParcelRepository
    {
        IEnumerable<ChildParentParcel> GetAll(decimal parcelNumber, DateTime? effectiveDate, string legalDocumentType,
                                              out int resultCount, int pageNumber = 1, int pageSize = 50);

        ChildParentParcelDetails Details(int id);
    }
}