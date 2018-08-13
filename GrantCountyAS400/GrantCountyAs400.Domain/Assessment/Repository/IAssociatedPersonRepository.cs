using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
   public interface IAssociatedPersonRepository
    {
        AssociatedPerson GetAssociatedPerson(decimal? parcelNumber, string nameCode);
    }
}
