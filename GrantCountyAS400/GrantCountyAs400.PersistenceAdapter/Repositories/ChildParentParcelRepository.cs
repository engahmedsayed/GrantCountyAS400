using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class ChildParentParcelRepository : IChildParentParcelRepository
    {
        private readonly GrantCountyDbContext _context;

        public ChildParentParcelRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<ParentParcel> GetAll(decimal parcelNumber, DateTime? effectiveDate, string legalDocumentType,
                                                out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<ParentParcel> results = new List<ParentParcel>();

            List<ParentParcel> parentRecords = new List<ParentParcel>();
            var query = (from parent in _context.AsmtparentChildRelationshipsChanged
                         join masterRecord in _context.AsmtrealPropertyAssessedValueMaster on parent.ParentParcel equals masterRecord.ParcelNumber
                         join names in _context.ASMTValueMasterNameView on parent.ParentParcel equals names.ParcelNumber
                         where ((parcelNumber <= 0) || (parent.ParentParcel == parcelNumber || parent.ChildParcel == parcelNumber))
                            && ((effectiveDate == null || effectiveDate.Value == null) || (parent.EffectiveDate == effectiveDate))
                            && ((string.IsNullOrWhiteSpace(legalDocumentType)) || (parent.LegalDocumentType.Trim().ToLower() == legalDocumentType.ToLower()))
                         group parent by new { parent.ParentParcel, names.TaxpayerName, names.TitleOwnerName } into parentGroup
                         orderby parentGroup.Key.TaxpayerName
                         select parentGroup.Key)
                         .Distinct()
                         .Select(t => new ParentParcel(t.ParentParcel.Value, t.TaxpayerName, t.TitleOwnerName));

            if (pageNumber > 0)
            {
                resultCount = query.Count();
                parentRecords = query.Skip((pageNumber - 1) * pageSize)
                                     .Take(pageSize)
                                     .ToList();
            }
            else
            {
                parentRecords = query.ToList();
                resultCount = parentRecords.Count();
            }

            var listOfRetrievedParentParcels = parentRecords.Select(parent => parent.ParcelNumber).ToList();

            var childRecords = _context.AsmtparentChildRelationshipsChanged
                                       .Where(child => listOfRetrievedParentParcels.Contains(child.ParentParcel.Value))
                                       .Select(ChildParentParcelMapper.Map)
                                       .ToList();

            foreach (var parent in parentRecords)
            {
                results.Add(new ParentParcel(
                    parent.ParcelNumber, parent.TaxPayerName, parent.TitleOwnerName,
                    childRecords.Where(child => child.ParentParcelNumber == parent.ParcelNumber)
                ));
            }

            return results;
        }

        public ChildParcelDetails Details(int id)
        {
            var query = (from child in _context.AsmtparentChildRelationshipsChanged
                         join masterRecord in _context.AsmtrealPropertyAssessedValueMaster on child.ChildParcel equals masterRecord.ParcelNumber
                         join names in _context.ASMTValueMasterNameView on child.ChildParcel equals names.ParcelNumber
                         where child.Id == id
                         select new { ChildParcel = child, ValueMasterNames = names, ValueMasterRecord = masterRecord }
                         ).SingleOrDefault();

            if (query != null)
            {
                var children = _context.AsmtparentChildRelationshipsChanged.Where(t => t.ParentParcel == query.ChildParcel.ChildParcel);
                return ChildParentParcelMapper.Map(query.ChildParcel, query.ValueMasterNames, query.ValueMasterRecord, children);
            }
            return null;
        }
    }
}