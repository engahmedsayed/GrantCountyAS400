using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Domain.Accounting.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class AccountPayableRepository : IAccountPayableRepository
    {
        private readonly GrantCountyDbContext _context;

        public AccountPayableRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<VenderWarrent> GetAll(
            string vendorId, string name, string representative, DateTime? minPayDate, DateTime? maxPayDate, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<VenderWarrent> results = new List<VenderWarrent>();
            var query = from warrent in _context.AcctApWarrant
                        join vendor in _context.AcctVendor on warrent.Vendor equals vendor.VendorId
                        where (string.IsNullOrEmpty(vendorId) || vendor.VendorId.ToLower() == vendorId.ToLower())
                        && (string.IsNullOrEmpty(name) || vendor.Name.ToLower().Contains(name.ToLower()))
                        && (string.IsNullOrEmpty(representative) || vendor.Representative.ToLower() == representative.ToLower())
                        && ((!minPayDate.HasValue) || warrent.PayDate >= minPayDate.Value)
                        && ((!maxPayDate.HasValue) || warrent.PayDate <= maxPayDate.Value)
                        select VenderWarrentMapper.Map(warrent, vendor);

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.Vendor)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.Vendor)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }
    }
}