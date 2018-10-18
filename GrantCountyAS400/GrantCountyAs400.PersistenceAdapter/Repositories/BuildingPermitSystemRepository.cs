using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
using GrantCountyAs400.PersistenceAdapter.Extensions;
using GrantCountyAs400.PersistenceAdapter.Mappers.Building;
using GrantCountyAs400.PersistenceAdapter.Models;
using System.Collections.Generic;
using System.Linq;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class BuildingPermitSystemRepository : IBuildingPermitSystemRepository
    {
        private readonly GrantCountyDbContext _context;

        public BuildingPermitSystemRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<BuildingPermitSystem> GetAll(decimal? applicationNumber, int? applicationYear, decimal? permitNumber, string applicantBusinessName,
                                                 string applicantLastName, string applicantFirstName, decimal? preliminaryParcelNumber, decimal? assessorParcelNumber,
                                                 string jurisdictionCode, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<BuildingPermitSystem> results = new List<BuildingPermitSystem>();
            var query = from appm in _context.BldgpermitApplicationMaster
                        where (applicationNumber == null || appm.ApplicationNumber == applicationNumber)
                        && (applicationYear == null || appm.ApplicationYear == applicationYear)
                        && (permitNumber == null || appm.PermitNumber == permitNumber)
                        && (string.IsNullOrWhiteSpace(applicantBusinessName) || appm.ApplicantBusinessName.TrimAndLower().Contains(applicantBusinessName.TrimAndLower()))
                        && (string.IsNullOrWhiteSpace(applicantLastName) || appm.ApplicantLastName.TrimAndLower().Contains(applicantLastName.TrimAndLower()))
                        && (string.IsNullOrWhiteSpace(applicantFirstName) || appm.ApplicantFirstName.TrimAndLower().Contains(applicantFirstName.TrimAndLower()))
                        && (preliminaryParcelNumber == null || appm.PreliminaryParcelNumber == preliminaryParcelNumber)
                        && (assessorParcelNumber == null || appm.AssessorParcelNumber == assessorParcelNumber)
                        && (string.IsNullOrWhiteSpace(jurisdictionCode) || appm.JurisdictionCode.TrimAndLower() == jurisdictionCode.TrimAndLower())
                        select BuildingPermitSystemMapper.Map(appm);
            if (pageNumber > 0)
            {
                resultCount = query.Count();
                results = query.Skip((pageNumber - 1) * pageSize)
                               .Take(pageSize)
                               .OrderBy(t => t.ApplicationDate)
                               .ToList();
            }
            else
            {
                results = query.OrderBy(t => t.ApplicationDate)
                               .ToList();
                resultCount = results.Count();
            }

            return results;
        }

        public BuildingPermitSystem Get(int id)
        {
            var result = (from appm in _context.BldgpermitApplicationMaster
                          where appm.Id == id
                          select BuildingPermitSystemMapper.Map(appm)).SingleOrDefault();
            return result;
        }

        public BuildingPermitSystemDetails Details(int id)
        {
            var query = (from bldgpermit in _context.BldgpermitApplicationMaster
                         join juri in _context.Bldgjurisdictions on bldgpermit.JurisdictionCode equals juri.DepartmentCode
                         join processedJuri in _context.Bldgjurisdictions on bldgpermit.ProcessedForJurisdiction equals processedJuri.DepartmentCode
                         join dept in _context.Bldgdepartments on bldgpermit.DepartmentCode equals dept.DepartmentCode
                         join perm in _context.BldgpermitCodes on bldgpermit.PermitCode equals perm.PermitCode
                         join preliminaryNames in _context.ASMTValueMasterNameView on bldgpermit.PreliminaryParcelNumber equals preliminaryNames.ParcelNumber
                         join assessorNames in _context.ASMTValueMasterNameView on bldgpermit.PreliminaryParcelNumber equals assessorNames.ParcelNumber
                         join bldgContractor in _context.Bldgcontractors on bldgpermit.ContractLicenseNumber equals bldgContractor.ContractLicenseNumber
                         join situs in _context.AsmtsitusAddress on bldgpermit.AssessorParcelNumber equals situs.ParcelNumber
                         into situsJoin
                         from situsRecord in situsJoin.DefaultIfEmpty()
                         join cityCode in _context.AsmtcityCodeFile on situsRecord.LocationCode equals cityCode.LocationCode
                         into cityCodeJoin
                         from cityCodeRecord in cityCodeJoin.DefaultIfEmpty()
                         join mdia in _context.BldgmobileHomeDealersInstallersArchitects on bldgpermit.ArchitectFirmNumber equals mdia.BusinessCode
                         into mdiaArchitectJoin
                         from mdiaArchitectRecord in mdiaArchitectJoin.DefaultIfEmpty()
                         join mdiaBusinessEngineer in _context.BldgmobileHomeDealersInstallersArchitects on bldgpermit.EngineerFirmNumber equals mdiaBusinessEngineer.BusinessCode
                         into mdiaEngineerJoin
                         from mdiaEngineerRecord in mdiaEngineerJoin.DefaultIfEmpty()
                         join plap in _context.BldgplanningApproval
                         on new { bldgpermit.ApplicationYear, bldgpermit.ApplicationNumber } equals new { plap.ApplicationYear, plap.ApplicationNumber }
                         into plapJoin
                         from plapRecord in plapJoin.DefaultIfEmpty()
                         where bldgpermit.Id == id
                         select BuildingPermitSystemMapper.Map(bldgpermit,
                                                               preliminaryNames,
                                                               assessorNames,
                                                               juri,
                                                               processedJuri,
                                                               dept,
                                                               perm,
                                                               situsRecord,
                                                               cityCodeRecord,
                                                               mdiaArchitectRecord,
                                                               mdiaEngineerRecord,
                                                               bldgContractor,
                                                               plapRecord)).SingleOrDefault();

            return query;
        }

        public DemolitionPermit GetDemolitionPermitByBuildingPermitSystemId(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join permit in _context.BldgdemolitionPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { permit.ApplicationYear, permit.ApplicationNumber }
                         join bldgFire in _context.BldgfireDistrictCodes on permit.FireDistrictCode equals bldgFire.FireDistrictCode
                         join bldgCondition in _context.BldgapplicationConditions
                         on new { permit.ApplicationYear, permit.ApplicationNumber } equals new { bldgCondition.ApplicationYear, bldgCondition.ApplicationNumber }
                         into bldgConditionJoin
                         from bldgConditionRecord in bldgConditionJoin.DefaultIfEmpty()
                         join bldgInspection in _context.BldgapplicationInspections
                         on new { permit.ApplicationYear, permit.ApplicationNumber } equals new { bldgInspection.ApplicationYear, bldgInspection.ApplicationNumber }
                         into bldgInspectionJoin
                         from bldgInspectionRecord in bldgInspectionJoin.DefaultIfEmpty()
                         where bldg.Id == id
                         select new { bldg, permit, bldgFire, bldgConditionRecord, bldgInspectionRecord }).FirstOrDefault();

            if (query != null)
            {
                return PermitDetailMapper.Map(query.bldg, query.permit, query.bldgFire, query.bldgConditionRecord, query.bldgInspectionRecord);
            }

            return null;
        }

        public OtherPermitDetail GetOtherPermitDetailByBuildingPermitSystemId(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join apcn in _context.BldgapplicationConditions
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { apcn.ApplicationYear, apcn.ApplicationNumber }
                         into apcnConditionJoin
                         from apcnConditionRecord in apcnConditionJoin.DefaultIfEmpty()
                         join apin in _context.BldgapplicationInspections
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { apin.ApplicationYear, apin.ApplicationNumber }
                         into apinConditionJoin
                         from apinConditionRecord in apinConditionJoin.DefaultIfEmpty()
                         join appv in _context.BldgapplicationValues
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { appv.ApplicationYear, appv.ApplicationNumber }
                         into appvCondition
                         from appvConditionRecord in appvCondition.DefaultIfEmpty()
                         join othd in _context.BldgotherPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { othd.ApplicationYear, othd.ApplicationNumber }
                         join fdst in _context.BldgfireDistrictCodes
                         on othd.FireDistrictCode equals fdst.FireDistrictCode
                         where bldg.Id == id
                         select new { bldg, apcnConditionRecord, apinConditionRecord, appvConditionRecord, othd, fdst }).FirstOrDefault();
            if (query != null)
            {
                return PermitDetailMapper.Map(query.othd, query.fdst, query.apcnConditionRecord, query.apinConditionRecord, query.appvConditionRecord);
            }
            return null;
        }

        public MechanicalPermitDetail GetMechanicalPermitDetailByBuildingPermitSystemId(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join mecd in _context.BldgmechanicalPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { mecd.ApplicationYear, mecd.ApplicationNumber }
                         join fdst in _context.BldgfireDistrictCodes
                         on mecd.FireDistrictCode equals fdst.FireDistrictCode
                         join apcn in _context.BldgapplicationConditions
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { apcn.ApplicationYear, apcn.ApplicationNumber }
                         into apcnConditionJoin
                         from apcnConditionRecord in apcnConditionJoin.DefaultIfEmpty()
                         join apin in _context.BldgapplicationInspections
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { apin.ApplicationYear, apin.ApplicationNumber }
                         into apinConditionJoin
                         from apinConditionRecord in apinConditionJoin.DefaultIfEmpty()
                         where bldg.Id == id
                         select new { bldg, apcnConditionRecord, apinConditionRecord, mecd, fdst }).FirstOrDefault();

            if (query != null)
            {
                return PermitDetailMapper.Map(query.bldg, query.apcnConditionRecord, query.apinConditionRecord, query.mecd, query.fdst);
            }
            return null;
        }

        public StructurePermitDetail GetStructurePermitDetailByBuildingPermitSystemId(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join strd in _context.BldgstructureBuildingPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { strd.ApplicationYear, strd.ApplicationNumber }
                         join fdst in _context.BldgfireDistrictCodes
                         on strd.FireDistrictCode equals fdst.FireDistrictCode
                         join apcn in _context.BldgapplicationConditions
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { apcn.ApplicationYear, apcn.ApplicationNumber }
                         into apcnConditionJoin
                         from apcnConditionRecord in apcnConditionJoin.DefaultIfEmpty()
                         join apin in _context.BldgapplicationInspections
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { apin.ApplicationYear, apin.ApplicationNumber }
                         into apinConditionJoin
                         from apinConditionRecord in apinConditionJoin.DefaultIfEmpty()
                         join appv in _context.BldgapplicationValues
                         on new { strd.ApplicationYear, strd.ApplicationNumber } equals new { appv.ApplicationYear, appv.ApplicationNumber }
                         into appvCondition
                         from appvConditionRecord in appvCondition.DefaultIfEmpty()
                         where bldg.Id == id
                         select new { bldg, apcnConditionRecord, apinConditionRecord, strd, fdst, appvConditionRecord }).FirstOrDefault();

            if (query != null)
            {
                return PermitDetailMapper.Map(query.bldg, query.apcnConditionRecord, query.apinConditionRecord, query.strd, query.fdst, query.appvConditionRecord);
            }
            return null;
        }

        public GradingExcavationPermitDetail GetGradingExcavationPermitDetail(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join grdd in _context.BldggradingExcavatingPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { grdd.ApplicationYear, grdd.ApplicationNumber }
                         join fdst in _context.BldgfireDistrictCodes
                         on grdd.FireDistrictCode equals fdst.FireDistrictCode
                         join apcn in _context.BldgapplicationConditions
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { apcn.ApplicationYear, apcn.ApplicationNumber }
                         into apcnConditionJoin
                         from apcnConditionRecord in apcnConditionJoin.DefaultIfEmpty()
                         join apin in _context.BldgapplicationInspections
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { apin.ApplicationYear, apin.ApplicationNumber }
                         into apinConditionJoin
                         from apinConditionRecord in apinConditionJoin.DefaultIfEmpty()
                         where bldg.Id == id
                         select new { bldg, fdst, apcnConditionRecord, apinConditionRecord, grdd }).FirstOrDefault();
            if (query != null)
            {
                return PermitDetailMapper.Map(query.bldg, query.fdst, query.apcnConditionRecord, query.apinConditionRecord, query.grdd);
            }
            return null;
        }

        public ManufactureModularPermit GetManufactureModularPermitByBuildingPermitSystemId(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join permit in _context.BldgmanufactureModularBuildingPermit
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { permit.ApplicationYear, permit.ApplicationNumber }
                         join bldgFire in _context.BldgfireDistrictCodes on permit.FireDistrictCode equals bldgFire.FireDistrictCode
                         join bldgCondition in _context.BldgapplicationConditions
                         on new { permit.ApplicationYear, permit.ApplicationNumber } equals new { bldgCondition.ApplicationYear, bldgCondition.ApplicationNumber }
                         into bldgConditionJoin
                         from bldgConditionRecord in bldgConditionJoin.DefaultIfEmpty()
                         join bldgInspection in _context.BldgapplicationInspections
                         on new { permit.ApplicationYear, permit.ApplicationNumber } equals new { bldgInspection.ApplicationYear, bldgInspection.ApplicationNumber }
                         into bldgInspectionJoin
                         from bldgInspectionRecord in bldgInspectionJoin.DefaultIfEmpty()
                         join bldgValue in _context.BldgapplicationValues
                         on new { permit.ApplicationYear, permit.ApplicationNumber } equals new { bldgValue.ApplicationYear, bldgValue.ApplicationNumber }
                         into bldgValueJoin
                         from bldgValueRecord in bldgValueJoin.DefaultIfEmpty()
                         join bldgDealer in _context.BldgmobileHomeDealersInstallersArchitects on permit.DealerNameCode equals bldgDealer.BusinessCode
                         into bldgDealerJoin
                         from bldgDealerRecord in bldgDealerJoin.DefaultIfEmpty()
                         join bldgInstaller in _context.BldgmobileHomeDealersInstallersArchitects on permit.CertInstallerCode equals bldgInstaller.BusinessCode
                         into bldgInstallerJoin
                         from bldgInstallerRecord in bldgInstallerJoin.DefaultIfEmpty()
                         where bldg.Id == id
                         select new { bldg, permit, bldgFire, bldgConditionRecord, bldgInspectionRecord, bldgValueRecord, bldgDealerRecord, bldgInstallerRecord }
                         ).FirstOrDefault();

            if (query != null)
            {
                return PermitDetailMapper.Map(
                    query.bldg,
                    query.permit,
                    query.bldgFire,
                    query.bldgConditionRecord,
                    query.bldgInspectionRecord,
                    query.bldgValueRecord,
                    query.bldgDealerRecord,
                    query.bldgInstallerRecord);
            }

            return null;
        }

        public PlumbingPermit GetPlumbingPermitByBuildingPermitSystemId(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join permit in _context.BldgplumbingPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { permit.ApplicationYear, permit.ApplicationNumber }
                         join bldgFire in _context.BldgfireDistrictCodes on permit.FireDistrictCode equals bldgFire.FireDistrictCode
                         join bldgCondition in _context.BldgapplicationConditions
                         on new { permit.ApplicationYear, permit.ApplicationNumber } equals new { bldgCondition.ApplicationYear, bldgCondition.ApplicationNumber }
                         into bldgConditionJoin
                         from bldgConditionRecord in bldgConditionJoin.DefaultIfEmpty()
                         join bldgInspection in _context.BldgapplicationInspections
                         on new { permit.ApplicationYear, permit.ApplicationNumber } equals new { bldgInspection.ApplicationYear, bldgInspection.ApplicationNumber }
                         into bldgInspectionJoin
                         from bldgInspectionRecord in bldgInspectionJoin.DefaultIfEmpty()
                         where bldg.Id == id
                         select new { bldg, permit, bldgFire, bldgConditionRecord, bldgInspectionRecord }
                         ).FirstOrDefault();

            if (query != null)
            {
                return PermitDetailMapper.Map(
                    query.bldg,
                    query.permit,
                    query.bldgFire,
                    query.bldgConditionRecord,
                    query.bldgInspectionRecord);
            }

            return null;
        }

        public ValuationAndFees GetValuationAndFees(int id, decimal? applicationYear, decimal? applicationNumber)
        {
            var query = (from appf in _context.BldgapplicationFees
                         join bldg in _context.BldgpermitApplicationMaster
                         on new { appf.ApplicationYear, appf.ApplicationNumber } equals new { bldg.ApplicationYear, bldg.ApplicationNumber }
                         join appv in _context.BldgapplicationValues
                         on new { appf.ApplicationYear, appf.ApplicationNumber } equals new { appv.ApplicationYear, appv.ApplicationNumber }
                         where bldg.Id == id &&
                               bldg.ApplicationYear == applicationYear &&
                               bldg.ApplicationNumber == applicationNumber
                         select new ValuationAndFeesRecord { Appv = appv, Appf = appf, Bldg = bldg }).ToList();

            return ValuationAndFeesMapper.Map(query);
        }

        public IEnumerable<BuildingInspection> GetInspectionsByBuildingPermitSystemId(int id)
        {
            var inspections = (from bldg in _context.BldgpermitApplicationMaster
                               join bldgInspection in _context.BldgapplicationInspections
                               on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { bldgInspection.ApplicationYear, bldgInspection.ApplicationNumber }
                               where bldg.Id == id
                               select BuildingInspectionMapper.Map(bldgInspection)).ToList();

            return inspections;
        }

        public IEnumerable<BuildingCondition> GetConditionsByBuildingPermitSystemId(int id)
        {
            var conditions = (from bldg in _context.BldgpermitApplicationMaster
                              join bldgCondition in _context.BldgapplicationConditions
                              on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { bldgCondition.ApplicationYear, bldgCondition.ApplicationNumber }
                              where bldg.Id == id
                              select BuildingConditionMapper.Map(bldgCondition)).ToList();

            return conditions;
        }

        public
            (IEnumerable<ReceiptHeader> ReceiptHeaders, IEnumerable<BuildingApplicationFee> BuildingApplicationFees)
            GetReceiptHeadersAndFeesByBuildingPermitSystemId(int id)
        {
            var receipts = (from bldg in _context.BldgpermitApplicationMaster
                            join receipt in _context.BldgapplcationReceiptHeader
                            on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { receipt.ApplicationYear, receipt.ApplicationNumber }
                            join receiptDetailRecord in _context.BldgapplcationReceiptDetail
                            on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { receiptDetailRecord.ApplicationYear, receiptDetailRecord.ApplicationNumber }
                            into receiptDetailJoin
                            from receiptDetail in receiptDetailJoin.DefaultIfEmpty()
                            join receiptCategory in _context.BldgfeeDistributionCategories
                            on receiptDetail.FeeDistributionCategory equals receiptCategory.FeeDistributionCategory
                            where bldg.Id == id
                            select new { receipt, receiptDetail, receiptCategory })
                            .ToList()
                            .GroupBy(t => t.receipt, t => (t.receiptCategory, t.receiptDetail))
                            .Select(group => ReceiptHeaderMapper.Map(group.Key, group.ToList()));

            var fees = (from bldg in _context.BldgpermitApplicationMaster
                        join fee in _context.BldgapplicationFees
                        on new { bldg.ApplicationYear, bldg.ApplicationNumber } equals new { fee.ApplicationYear, fee.ApplicationNumber }
                        where bldg.Id == id
                        select BuildingApplicationFeeMapper.Map(fee)).ToList();

            return (receipts, fees);
        }
    }

    internal class ValuationAndFeesRecord
    {
        public BldgapplicationFees Appf { get; set; }
        public BldgpermitApplicationMaster Bldg { get; set; }
        public BldgapplicationValues Appv { get; set; }
    }
}