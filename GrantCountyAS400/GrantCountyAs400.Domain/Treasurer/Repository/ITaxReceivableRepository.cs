using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Treasurer.Repository
{
    public interface ITaxReceivableRepository
    {
        IEnumerable<TaxReceivable> GetAll(decimal minParcelNumber, decimal? maxParcelNumber, out int resultCount, int pageNumber = 1, int pageSize = 50);

        TaxReceivableDetails Details(decimal parcelNumber, decimal parcelExtension);
    }
}