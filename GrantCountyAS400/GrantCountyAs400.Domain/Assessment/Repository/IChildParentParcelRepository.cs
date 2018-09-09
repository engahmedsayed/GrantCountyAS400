using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IChildParentParcelRepository
    {
        IEnumerable<ParentParcel> GetAll(decimal parcelNumber, out int resultCount, int pageNumber = 1, int pageSize = 50);

        ChildParcelDetails Details(int id);
    }
}