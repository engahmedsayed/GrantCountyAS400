using GrantCountyAs400.Domain;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class AddressSearchRepository : IAddressSearchRepository
    {
        private readonly GrantCountyDbContext _context;

        public AddressSearchRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<AddressSearch> GetAll(decimal parcelNumber, decimal houseNumber, string streetName, out int resultCount,
                                                 int pageNumber = 1, int pageSize = 50)
        {
            List<AddressSearch> results = new List<AddressSearch>();

            var query = (from situsAddress in _context.AsmtsitusAddress
                         join cityCode in _context.AsmtcityCodeFile
                         on situsAddress.LocationCode equals cityCode.LocationCode
                         where (parcelNumber <= 0 || situsAddress.ParcelNumber == parcelNumber)
                         && (houseNumber <= 0 || situsAddress.HouseNumber == houseNumber)
                         && (string.IsNullOrWhiteSpace(streetName) ||
                            situsAddress.StreetName.Trim().ToLower() == streetName.Trim().ToLower())
                         select AddressSearchMapper.Map(situsAddress, cityCode));
            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.ParcelNumber)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.ParcelNumber)
                               .ToList();
                resultCount = results.Count();
            }

            return results;

        }
    }
}
