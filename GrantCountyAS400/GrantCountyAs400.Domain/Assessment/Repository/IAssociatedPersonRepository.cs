using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
   public interface IAssociatedPersonRepository
    {
        AssociatedPerson GetAssociatedPerson(decimal? parcelNumber, string nameCode);

        List<AssociatedPersonMain> GetAssociatedPersonMain(decimal? parcelNumber, string nameCodeout,out int resultCount, int pageNumber = 1, int pageSize = 50);
    }
}
