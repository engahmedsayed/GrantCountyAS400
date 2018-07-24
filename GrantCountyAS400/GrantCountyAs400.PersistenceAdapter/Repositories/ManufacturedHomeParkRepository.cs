using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class ManufacturedHomeParkRepository : IManufacturedHomeParkRepository
    {
        private readonly GrantCountyDbContext _context;

        public ManufacturedHomeParkRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<ManufacturedHomePark> GetAll(string parkCode, string parkName, string contactName, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<ManufacturedHomePark> results = new List<ManufacturedHomePark>();

            var query = from homepark in _context.AsmtmobileHomeParks
                        join nameAddress in _context.AsmtmasterNameAddress on homepark.ContactNameCode equals nameAddress.NameCode
                        into homeparkDetails
                        from nameAddressRecord in homeparkDetails.DefaultIfEmpty()
                        where (string.IsNullOrWhiteSpace(parkCode) || homepark.MhparkCode.Trim() == parkCode.Trim())
                        && (string.IsNullOrWhiteSpace(parkName) || homepark.Name.Trim().Contains(parkName.Trim()))
                        && (string.IsNullOrWhiteSpace(contactName) || nameAddressRecord.Name.Trim().Contains(contactName.Trim()))
                        select ManufacturedHomeParkMapper.Map(homepark, nameAddressRecord);

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.MhparkCode)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.MhparkCode)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }

        public ManufacturedHomeParkDetails Details(int id)
        {
            var homepark = (from homeparkRecord in _context.AsmtmobileHomeParks
                            join valueMasterRecord in _context.AsmtrealPropertyAssessedValueMaster on homeparkRecord.ParcelNumber
                            equals valueMasterRecord.ParcelNumber into homepark_valueMasterRecord
                            join nameAddress in _context.AsmtmasterNameAddress on homeparkRecord.ContactNameCode
                            equals nameAddress.NameCode into homepark_nameAddressRecord
                            where homeparkRecord.Id == id
                            from valueMasterRecord in homepark_valueMasterRecord.DefaultIfEmpty()
                            from nameAddressRecord in homepark_nameAddressRecord.DefaultIfEmpty()
                            select ManufacturedHomeParkMapper.Map(homeparkRecord, nameAddressRecord, valueMasterRecord)
                            ).SingleOrDefault();

            return homepark;
        }
    }
}