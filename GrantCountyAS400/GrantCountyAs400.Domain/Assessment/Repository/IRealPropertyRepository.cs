﻿using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IRealPropertyRepository
    {
        IEnumerable<RealProperty> GetAll(decimal minParcelNumber, decimal? maxParcelNumber, string taxpayer, string owner, string contractHolder, decimal taxcodeArea,
                                         out int resultCount, int pageNumber = 1, int pageSize = 50);

        RealPropertyDetails Details(int id);
    }
}