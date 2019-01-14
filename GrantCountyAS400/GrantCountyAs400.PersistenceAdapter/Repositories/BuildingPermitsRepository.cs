using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Mappers.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class BuildingPermitsRepository : IBuildingPermitsRepository
    {
        private readonly GrantCountyDbContext _context;
        public BuildingPermitsRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<BuildingPermitsMain> GetBuldingPermitsMain(decimal? parcelNumber,out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<BuildingPermitsMain> results = new List<BuildingPermitsMain>();
            var query = from RPAV in _context.AsmtrealPropertyAssessedValueMaster
                        join NNAME in _context.AsmtmasterNameAddress
                        on RPAV.TaxpayerCode equals NNAME.NameCode
                        where ((parcelNumber == null) || (parcelNumber == 0) || (RPAV.ParcelNumber == parcelNumber))
                        select BuildingPermitsMapper.Map(RPAV, NNAME);

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

        public HistoricValuesMain GetHistoricValues(decimal? parcelNumber, string taxPayerCode, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            var query = (from rpavm in _context.AsmtrealPropertyAssessedValueMaster
                         join RPHV in _context.TreasrealPropertyHistoricValues
                         on   rpavm.ParcelNumber  equals   RPHV.ParcelNumber 
                         join NNAME in _context.AsmtmasterNameAddress
                         on rpavm.TaxpayerCode equals NNAME.NameCode
                         where ((parcelNumber == null) || (parcelNumber == 0) || (rpavm.ParcelNumber == parcelNumber))
                         && ((string.IsNullOrWhiteSpace(taxPayerCode)) || (taxPayerCode == rpavm.TaxpayerCode))
                         orderby rpavm.TaxYear descending
                         select new { rpavm = rpavm, rphv = RPHV, nname = NNAME });
            if (query != null)
            {
                var result = new HistoricValuesMain();
                result.Items = new List<HistoricValuesItems>();
                if (pageNumber > 0)
                {
                    var filterdResults = query.Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .OrderByDescending(t => t.rphv.TaxYear)
                                      .ToList();
                    foreach (var item in filterdResults)
                    {
                        result.Items.Add(new HistoricValuesItems(item.rpavm?.ParcelNumber,(int)item.rphv?.TaxYear,item.rphv?.RevaluationPhase,
                                                                item.rpavm?.TaxpayerCode +" " + item.nname?.Name, item.rphv?.TaxCodeArea,item.rpavm?.Description1,item.rpavm?.Description2,
                                                                item.rpavm?.Description3,item.rpavm?.Description4,item.rphv?.LandUseCode,item?.rphv.TaxStatus,
                                                                item.rphv?.BuildingValue,item.rphv?.ImprovedLandValue,item.rphv?.UnimprovedLandValue,
                                                                item.rphv?.UndividedInterestPercent,item.rphv?.SubsidiaryParcelCode,item.rphv?.UnimprovedLandAcres,
                                                                item.rphv?.ImprovedLandAcres,item.rphv?.FirePatrolAcres,item.rphv?.MobileHomeValue,item.rphv?.ChangeReasonCode));
                    }
                    resultCount = query.Count();
                }
                else
                {
                    foreach (var item in query.OrderByDescending(t=>t.rpavm.TaxYear))
                    {
                        result.Items.Add(new HistoricValuesItems(item.rpavm?.ParcelNumber, (int)item.rphv?.TaxYear, item.rphv?.RevaluationPhase,
                                                                item.rpavm?.TaxpayerCode +" " + item.nname?.Name, item.rphv?.TaxCodeArea, item.rpavm?.Description1, item.rpavm?.Description2,
                                                                item.rpavm?.Description3, item.rpavm?.Description4, item.rphv?.LandUseCode, item?.rphv.TaxStatus,
                                                                item.rphv?.BuildingValue, item.rphv?.ImprovedLandValue, item.rphv?.UnimprovedLandValue,
                                                                item.rphv?.UndividedInterestPercent, item.rphv?.SubsidiaryParcelCode, item.rphv?.UnimprovedLandAcres,
                                                                item.rphv?.ImprovedLandAcres, item.rphv?.FirePatrolAcres, item.rphv?.MobileHomeValue, item.rphv?.ChangeReasonCode));
                    }
                    resultCount = result.Items.Count();
                }
                return result;
            }
            resultCount = 0;
            return null;
        }

        public BuildingPermits GetParcelBuildingPermits(decimal parcelNumber, string ownerCode)
        {
            var parcelNumberWithTaxPayerCodeQuery = (from RPAV in _context.AsmtrealPropertyAssessedValueMaster
                        join NNAME in _context.AsmtmasterNameAddress
                        on RPAV.TaxpayerCode equals NNAME.NameCode
                        where RPAV.ParcelNumber == parcelNumber && RPAV.TitleOwnerCode == ownerCode
                        select new { RPAV, NNAME }).FirstOrDefault();

            var parcelNumberWithTitleOwnerCodeQuery = (from RPAV in _context.AsmtrealPropertyAssessedValueMaster
                                                       join NNAME in _context.AsmtmasterNameAddress
                                                       on RPAV.TitleOwnerCode equals NNAME.NameCode
                                                       where RPAV.ParcelNumber == parcelNumber && RPAV.TaxpayerCode == ownerCode
                                                       select new { RPAV, NNAME }).FirstOrDefault();

            var parcelNumberWithLandUseCodeQuery = (from RPAV in _context.AsmtrealPropertyAssessedValueMaster
                                                    join LU in _context.AsmtlandUseCodes
                                                    on RPAV.LandUseCode equals LU.LandUseCode
                                                    where RPAV.ParcelNumber == parcelNumber && RPAV.TaxpayerCode == ownerCode
                                                    select new { RPAV, LU }).FirstOrDefault();

            var lineValuesQuery = (from RPAV in _context.AsmtrealPropertyAssessedValueMaster
                                   join PM in _context.AsmtpermitMaster
                                   on RPAV.ParcelNumber equals PM.ParcelNumber
                                   where RPAV.ParcelNumber == parcelNumber && RPAV.TitleOwnerCode == ownerCode
                                   select PM );
            List<BuildingPermitsLineValue> lineValues = new List<BuildingPermitsLineValue>();
            foreach (var item in lineValuesQuery)
            {
                lineValues.Add(new BuildingPermitsLineValue(item.PermitNumber,item.PermitYear, item.PermitAddendum, item.PermitIssuedDate
                                                           , item.JurisdictionCode, item.PercentComplete, item.EstimatedValue
                                                           , item.NewOrDemo, item.Comments));
            }

            BuildingPermits result = new BuildingPermits(parcelNumberWithTaxPayerCodeQuery?.RPAV?.ParcelNumber, parcelNumberWithTaxPayerCodeQuery?.NNAME?.Name
                                                         , parcelNumberWithTitleOwnerCodeQuery?.NNAME?.Name, parcelNumberWithTaxPayerCodeQuery?.RPAV?.Description1
                                                         , parcelNumberWithLandUseCodeQuery?.LU?.UseCodeDesc, parcelNumberWithTaxPayerCodeQuery?.RPAV?.Description2
                                                         , parcelNumberWithTaxPayerCodeQuery?.RPAV?.UnimprovedLandAcres + parcelNumberWithTaxPayerCodeQuery?.RPAV?.ImprovedLandAcers
                                                         , parcelNumberWithTaxPayerCodeQuery?.RPAV?.Description3, parcelNumberWithTaxPayerCodeQuery?.RPAV?.ImprovedLandValue
                                                         , parcelNumberWithTaxPayerCodeQuery?.RPAV?.Description4, parcelNumberWithTaxPayerCodeQuery?.RPAV?.BuildingValue
                                                         , lineValues);

            return result;
        }
    }
}
