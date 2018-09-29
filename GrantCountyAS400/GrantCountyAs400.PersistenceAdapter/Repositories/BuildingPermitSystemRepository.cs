﻿using GrantCountyAs400.Domain.Building;
using GrantCountyAs400.Domain.Building.Repository;
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

        public List<BuildingPermitSystem> GetAll(decimal? applicationNumber, int? applicationYear, string departmentCode, string jurisdictionCode,
                                                 out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<BuildingPermitSystem> results = new List<BuildingPermitSystem>();
            var query = from appm in _context.BldgpermitApplicationMaster
                        where (appm.ApplicationNumber == applicationNumber || applicationNumber == null)
                        && (appm.ApplicationYear == applicationYear || applicationYear == null)
                        && (appm.DepartmentCode == departmentCode || string.IsNullOrWhiteSpace(departmentCode))
                        && (appm.JurisdictionCode == jurisdictionCode || string.IsNullOrWhiteSpace(jurisdictionCode))
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
                         select new { bldg,apcnConditionRecord,apinConditionRecord,appvConditionRecord, othd, fdst }).FirstOrDefault();
            if(query != null)
            {
                return PermitDetailMapper.Map(query.othd, query.fdst,query.apcnConditionRecord,query.apinConditionRecord,query.appvConditionRecord);
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

            if(query != null)
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
            if(query != null)
            {
                return PermitDetailMapper.Map(query.bldg, query.fdst, query.apcnConditionRecord, query.apinConditionRecord, query.grdd);
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
                         where  bldg.Id == id && 
                                bldg.ApplicationYear == applicationYear && 
                                bldg.ApplicationNumber == applicationNumber 
                         select new ValuationAndFeesClass{ Appv=appv, Appf=appf, Bldg=bldg }).ToList();

            return ValuationAndFeesMapper.Map(query);
        }
    }
    internal class ValuationAndFeesClass
    {
        public BldgapplicationFees Appf { get; set; }
        public BldgpermitApplicationMaster Bldg { get; set; }
        public BldgapplicationValues Appv { get; set; }
    }
}