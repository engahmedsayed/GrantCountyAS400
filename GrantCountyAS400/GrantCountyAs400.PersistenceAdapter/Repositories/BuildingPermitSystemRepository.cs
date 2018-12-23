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

        public List<BuildingPermitSystem> GetAll(BuildingSearchCriteria searchCriteria, out int resultCount, int pageNumber = 1, int pageSize = 50)
        {
            List<BuildingPermitSystem> results = new List<BuildingPermitSystem>();
            IQueryable<BuildingPermitSystem> query = null;
            const string gradString = "grad";
            const string mechString = "mech";
            const string firemString = "firem";
            const string demoString = "demo";
            const string manhString = "manh";
            const string plmbString = "plmb";
            const string strutString = "strut";
            query = from appm in _context.BldgpermitApplicationMaster
                    join ctr in _context.Bldgcontractors
                    on appm.ContractLicenseNumber equals ctr.ContractLicenseNumber
                    join grd in _context.BldggradingExcavatingPermitDetail on
                    new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber, permitCode = appm.PermitCode.TrimAndLower() } equals new { grd.ApplicationYear, grd.ApplicationNumber, grd.AddendumNumber, permitCode = gradString }
                    into grdRecordrs
                    from grdRecord in grdRecordrs.DefaultIfEmpty()
                    join mech in _context.BldgmechanicalPermitDetail on
                    new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber, permitCode = appm.PermitCode.TrimAndLower() } equals new { mech.ApplicationYear, mech.ApplicationNumber, mech.AddendumNumber, permitCode = mechString }
                    into mechRecords
                    from mechRecord in mechRecords.DefaultIfEmpty()
                    join firem in _context.BldgotherPermitDetail on
                    new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber, permitCode = appm.PermitCode.TrimAndLower() } equals new { firem.ApplicationYear, firem.ApplicationNumber, firem.AddendumNumber, permitCode = firemString }
                    into firemRecords
                    from firemRecord in firemRecords.DefaultIfEmpty()
                    join demo in _context.BldgdemolitionPermitDetail on
                    new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber, permitCode = appm.PermitCode.TrimAndLower() } equals new { demo.ApplicationYear, demo.ApplicationNumber, demo.AddendumNumber, permitCode = demoString }
                    into demoRecords
                    from demoRecord in demoRecords.DefaultIfEmpty()
                    join manh in _context.BldgmanufactureModularBuildingPermit on
                    new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber, permitCode = appm.PermitCode.TrimAndLower() } equals new { manh.ApplicationYear, manh.ApplicationNumber, manh.AddendumNumber, permitCode = manhString }
                    into manhRecords
                    from manhRecord in manhRecords.DefaultIfEmpty()
                    join plmb in _context.BldgplumbingPermitDetail on
                    new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber, permitCode = appm.PermitCode.TrimAndLower() } equals new { plmb.ApplicationYear, plmb.ApplicationNumber, plmb.AddendumNumber, permitCode = plmbString }
                    into plmbRecords
                    from plmbRecord in plmbRecords.DefaultIfEmpty()
                    join strut in _context.BldgstructureBuildingPermitDetail on
                    new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber, permitCode = appm.PermitCode.TrimAndLower() } equals new { strut.ApplicationYear, strut.ApplicationNumber, strut.AddendumNumber, permitCode = strutString }
                    into strutRecords
                    from strutRecord in strutRecords.DefaultIfEmpty()
                    where (searchCriteria.ApplicationNumber == null || appm.ApplicationNumber == searchCriteria.ApplicationNumber)
                    && (searchCriteria.ApplicationYear == null || appm.ApplicationYear == searchCriteria.ApplicationYear)
                    && (searchCriteria.PermitNumber == null || appm.PermitNumber == searchCriteria.PermitNumber)
                    && (searchCriteria.PermitYear == null || appm.PermitYear == searchCriteria.PermitYear)
                    && (string.IsNullOrWhiteSpace(searchCriteria.ApplicantBusinessName) || appm.ApplicantBusinessName.TrimAndLower().Contains(searchCriteria.ApplicantBusinessName.TrimAndLower()))
                    && (string.IsNullOrWhiteSpace(searchCriteria.ApplicantLastName) || appm.ApplicantLastName.TrimAndLower().Contains(searchCriteria.ApplicantLastName.TrimAndLower()))
                    && (string.IsNullOrWhiteSpace(searchCriteria.ApplicantFirstName) || appm.ApplicantFirstName.TrimAndLower().Contains(searchCriteria.ApplicantFirstName.TrimAndLower()))
                    && (searchCriteria.PreliminaryParcelNumber == null || appm.PreliminaryParcelNumber == searchCriteria.PreliminaryParcelNumber)
                    && (searchCriteria.AssessorParcelNumber == null || appm.AssessorParcelNumber == searchCriteria.AssessorParcelNumber)
                    && (searchCriteria.StateClassCode == null || appm.StateClassCode == searchCriteria.StateClassCode)
                    && (string.IsNullOrWhiteSpace(searchCriteria.ProjectDescription) || appm.ApplicantProjectDescription.TrimAndLower().Contains(searchCriteria.ProjectDescription.TrimAndLower()))
                    && (string.IsNullOrWhiteSpace(searchCriteria.ContractorBusinessName) || ctr.ContractorBusinessName.TrimAndLower().Contains(searchCriteria.ContractorBusinessName))
                    && (string.IsNullOrWhiteSpace(searchCriteria.EnforcementActionDesc) || appm.EnforcementDescription.Contains(searchCriteria.EnforcementActionDesc))
                    && (string.IsNullOrWhiteSpace(searchCriteria.CityApproval) ||
                        (appm.CityJurisdictionApprovalRequired.TrimAndLower() == searchCriteria.CityApproval.TrimAndLower() ||
                         appm.CityUtilityApprovalRequired.TrimAndLower() == searchCriteria.CityApproval.TrimAndLower()))
                    && ((!searchCriteria.FromDate.HasValue) || appm.PermitIssuedDate >= searchCriteria.FromDate)
                    && ((!searchCriteria.ToDate.HasValue) || appm.PermitIssuedDate <= searchCriteria.ToDate)
                    select BuildingPermitSystemMapper.Map(appm, appm.PermitCode.TrimAndLower() == gradString ? grdRecord.OfficeProjectDescription :
                                                          appm.PermitCode.TrimAndLower() == mechString ? mechRecord.OfficeProjectDescription :
                                                          appm.PermitCode.TrimAndLower() == firemString ? firemRecord.OfficeProjectDescription :
                                                          appm.PermitCode.TrimAndLower() == demoString ? demoRecord.OfficeProjectDescription :
                                                          appm.PermitCode.TrimAndLower() == manhString ? manhRecord.OfficeProjectDescription :
                                                          appm.PermitCode.TrimAndLower() == plmbString ? plmbRecord.OfficeProjectDescription :
                                                          appm.PermitCode.TrimAndLower() == strutString ? strutRecord.OfficeProjectDescription : string.Empty, ctr.ContractorBusinessName);
            if (!string.IsNullOrWhiteSpace(searchCriteria.OfficeProjectDescription))
            {
                query = query.Where(t => !string.IsNullOrWhiteSpace(t.OfficeProjectDescription) && t.OfficeProjectDescription.TrimAndLower().Contains(searchCriteria.OfficeProjectDescription.TrimAndLower()));
            }

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

        private string GetOfficeProjectDescription(GrantCountyDbContext context, string permitCode, string officeProjectDesc, decimal? applicationYear, decimal? applicationNumber)
        {
            string result;
            switch (permitCode)
            {
                case "grad":
                    result = (from appm in context.BldgpermitApplicationMaster
                              join grd in context.BldggradingExcavatingPermitDetail
                              on new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber } equals new { grd.ApplicationYear, grd.ApplicationNumber, grd.AddendumNumber }
                              where
                              ((string.IsNullOrWhiteSpace(officeProjectDesc) || grd.OfficeProjectDescription.TrimAndLower().Contains(officeProjectDesc.TrimAndLower())) &&
                              appm.ApplicationYear == applicationYear && appm.ApplicationNumber == applicationNumber)
                              select grd.OfficeProjectDescription).FirstOrDefault();
                    break;

                case "mech":
                    result = (from appm in context.BldgpermitApplicationMaster
                              join mech in context.BldgmechanicalPermitDetail
                              on new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber } equals new { mech.ApplicationYear, mech.ApplicationNumber, mech.AddendumNumber }
                              where ((string.IsNullOrWhiteSpace(officeProjectDesc) || mech.OfficeProjectDescription.TrimAndLower().Contains(officeProjectDesc.TrimAndLower())) &&
                              appm.ApplicationYear == applicationYear && appm.ApplicationNumber == applicationNumber)
                              select mech.OfficeProjectDescription).FirstOrDefault();
                    break;

                case "firem":

                    result = (from appm in _context.BldgpermitApplicationMaster
                              join firem in _context.BldgotherPermitDetail
                              on new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber } equals new { firem.ApplicationYear, firem.ApplicationNumber, firem.AddendumNumber }
                              select firem.OfficeProjectDescription).FirstOrDefault();
                    break;

                case "demo":
                    result = (from appm in context.BldgpermitApplicationMaster
                              join demo in context.BldgdemolitionPermitDetail
                              on new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber } equals new { demo.ApplicationYear, demo.ApplicationNumber, demo.AddendumNumber }
                              where ((string.IsNullOrWhiteSpace(officeProjectDesc) || demo.OfficeProjectDescription.TrimAndLower().Contains(officeProjectDesc.TrimAndLower())) &&
                              appm.ApplicationYear == applicationYear && appm.ApplicationNumber == applicationNumber)
                              select demo.OfficeProjectDescription).FirstOrDefault();
                    break;

                case "manh":
                    result = (from appm in context.BldgpermitApplicationMaster
                              join manh in context.BldgmanufactureModularBuildingPermit
                              on new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber } equals new { manh.ApplicationYear, manh.ApplicationNumber, manh.AddendumNumber }
                              where ((string.IsNullOrWhiteSpace(officeProjectDesc) || manh.OfficeProjectDescription.TrimAndLower().Contains(officeProjectDesc.TrimAndLower())) &&
                              appm.ApplicationYear == applicationYear && appm.ApplicationNumber == applicationNumber)
                              select manh.OfficeProjectDescription).FirstOrDefault();
                    break;

                case "plmb":
                    result = (from appm in context.BldgpermitApplicationMaster
                              join plmp in context.BldgplumbingPermitDetail
                              on new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber } equals new { plmp.ApplicationYear, plmp.ApplicationNumber, plmp.AddendumNumber }
                              where ((string.IsNullOrWhiteSpace(officeProjectDesc) || plmp.OfficeProjectDescription.TrimAndLower().Contains(officeProjectDesc.TrimAndLower())) &&
                              appm.ApplicationYear == applicationYear && appm.ApplicationNumber == applicationNumber)
                              select plmp.OfficeProjectDescription).FirstOrDefault();
                    break;

                case "strut":
                    result = (from appm in context.BldgpermitApplicationMaster
                              join strut in context.BldgstructureBuildingPermitDetail
                              on new { appm.ApplicationYear, appm.ApplicationNumber, appm.AddendumNumber } equals new { strut.ApplicationYear, strut.ApplicationNumber, strut.AddendumNumber }
                              where ((string.IsNullOrWhiteSpace(officeProjectDesc) || strut.OfficeProjectDescription.TrimAndLower().Contains(officeProjectDesc.TrimAndLower())) &&
                              appm.ApplicationYear == applicationYear && appm.ApplicationNumber == applicationNumber)
                              select strut.OfficeProjectDescription).FirstOrDefault();
                    break;

                default:
                    result = string.Empty;
                    break;
            }
            return result;
        }

        public BuildingPermitSystem Get(int id)
        {
            var result = (from appm in _context.BldgpermitApplicationMaster
                          join ctr in _context.Bldgcontractors
                          on appm.ContractLicenseNumber equals ctr.ContractLicenseNumber
                          where appm.Id == id
                          select BuildingPermitSystemMapper.Map(appm, GetOfficeProjectDescription(_context, appm.PermitCode, string.Empty, appm.ApplicationYear, appm.ApplicationNumber), ctr.ContractorBusinessName)).SingleOrDefault();
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
                         into bldgContractorJoin
                         from bldgContractorRecord in bldgContractorJoin.DefaultIfEmpty()
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
                         join rpmas in _context.AsmtrealPropertyAssessedValueMaster
                         on bldgpermit.AssessorParcelNumber
                         equals rpmas.ParcelNumber
                         into rpmasJoin
                         from rpmasRecord in rpmasJoin.DefaultIfEmpty()
                         join nName in _context.AsmtmasterNameAddress
                         on rpmasRecord.TitleOwnerCode equals nName.Name
                         into nNameJoin
                         from nNameRecord in nNameJoin.DefaultIfEmpty()
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
                                                               bldgContractorRecord,
                                                               rpmasRecord, nNameRecord)).SingleOrDefault();
            if (query != null && query.ApprovalStatus != null)
            {
                if (query.ApprovalStatus.Planning != null &&
                   query.ApprovalStatus.Planning.Required.ToLower() == "y" &&
                   query.ApprovalStatus.Planning.Date.HasValue)
                {
                    var planningApproval = (from bldgpermit in _context.BldgpermitApplicationMaster
                                            join plap in _context.BldgplanningApproval
                        on new { bldgpermit.ApplicationYear, bldgpermit.ApplicationNumber, bldgpermit.AddendumNumber }
                        equals new { plap.ApplicationYear, plap.ApplicationNumber, plap.AddendumNumber }
                        into plapJoin
                                            from plapRecord in plapJoin.DefaultIfEmpty()
                                            where bldgpermit.Id == id
                                            select new { plapRecord = plapRecord, bldgpermit = bldgpermit }).SingleOrDefault();
                    query.SetPlanningApproval(
                          BuildingPermitSystemMapper.MapToPlanningApproval(planningApproval.plapRecord,
                                                                           planningApproval.bldgpermit));
                }
                if (query.ApprovalStatus.Assessor != null &&
                    query.ApprovalStatus.Assessor.Required.ToLower() == "y" &&
                    query.ApprovalStatus.Assessor.Date.HasValue)
                {
                    var assessorApproval = (from bldgpermit in _context.BldgpermitApplicationMaster
                                            join assessor in _context.BldgassessorApproval
                                            on new { bldgpermit.ApplicationYear, bldgpermit.ApplicationNumber, bldgpermit.AddendumNumber }
                                            equals new { assessor.ApplicationYear, assessor.ApplicationNumber, assessor.AddendumNumber }
                                            into assessorJoin
                                            from assessorRecord in assessorJoin.DefaultIfEmpty()
                                            join rpmas in _context.AsmtrealPropertyAssessedValueMaster
                                            on bldgpermit.AssessorParcelNumber equals rpmas.ParcelNumber
                                            into rpmasJoin
                                            from rpmasRecord in rpmasJoin.DefaultIfEmpty()
                                            join nName in _context.AsmtmasterNameAddress
                                            on rpmasRecord.TitleOwnerCode equals nName.NameCode
                                            into nNameJoin
                                            from nNameRecord in nNameJoin.DefaultIfEmpty()
                                            where bldgpermit.Id == id
                                            select new
                                            {
                                                bldgpermit = bldgpermit,
                                                assessorRecord = assessorRecord,
                                                rpmasRecord = rpmasRecord,
                                                nNameRecord = nNameRecord
                                            }).SingleOrDefault();
                    query.SetAssessorApproval(BuildingPermitSystemMapper.MaptToAssessorApproval(assessorApproval.rpmasRecord,
                                                                                                assessorApproval.assessorRecord,
                                                                                                assessorApproval.nNameRecord,
                                                                                                assessorApproval.bldgpermit));
                }
                if (query.ApprovalStatus.PublicWroks != null &&
                    query.ApprovalStatus.PublicWroks.Required.ToLower() == "y" &&
                    query.ApprovalStatus.PublicWroks.Date.HasValue)
                {
                    var publicWorkAppproval = (from bldgpermit in _context.BldgpermitApplicationMaster
                                               join publicWork in _context.BldgpublicWorksApproval
                                               on new { bldgpermit.ApplicationYear, bldgpermit.ApplicationNumber, bldgpermit.AddendumNumber }
                                             equals new { publicWork.ApplicationYear, publicWork.ApplicationNumber, publicWork.AddendumNumber }
                                             into publicWorkJoin
                                               from publicWorkRecord in publicWorkJoin.DefaultIfEmpty()
                                               where bldgpermit.Id == id
                                               select new
                                               {
                                                   bldgpermit = bldgpermit,
                                                   publicWorkRecord = publicWorkRecord
                                               }).SingleOrDefault();
                    query.SetPublicWorkApproval(BuildingPermitSystemMapper.MapToPublicWorkApproval(publicWorkAppproval.bldgpermit,
                                                publicWorkAppproval.publicWorkRecord));
                }
                if (query.ApprovalStatus.Health != null &&
                    query.ApprovalStatus.Health.Required.ToLower() == "y" &&
                    query.ApprovalStatus.Health.Date.HasValue)
                {
                    var healthApproval = (from bldgpermit in _context.BldgpermitApplicationMaster
                                          join health in _context.BldghealthApproval
                                          on new { bldgpermit.ApplicationYear, bldgpermit.ApplicationNumber, bldgpermit.AddendumNumber }
                                              equals new { health.ApplicationYear, health.ApplicationNumber, health.AddendumNumber }
                                              into healthJoin
                                          from healthJoinRecord in healthJoin.DefaultIfEmpty()
                                          where bldgpermit.Id == id
                                          select new
                                          {
                                              bldgpermit = bldgpermit,
                                              healthRecord = healthJoinRecord
                                          }).SingleOrDefault();
                    query.SetHealthApproval(BuildingPermitSystemMapper.MapToHealthApproval(healthApproval.bldgpermit,
                                            healthApproval.healthRecord));
                }
                if (query.ApprovalStatus.CityUtility != null &&
                    query.ApprovalStatus.CityUtility.Required.ToLower() == "y" &&
                    query.ApprovalStatus.CityUtility.Date.HasValue)
                {
                    var cityApproval = (from bldgpermit in _context.BldgpermitApplicationMaster
                                        join city in _context.BldgcityApproval
                                        on new { bldgpermit.ApplicationYear, bldgpermit.ApplicationNumber, bldgpermit.AddendumNumber }
                                               equals new { city.ApplicationYear, city.ApplicationNumber, city.AddendumNumber }
                                               into cityJoin
                                        from cityJoinRecord in cityJoin.DefaultIfEmpty()
                                        join jurisdiction in _context.Bldgjurisdictions
                                        on cityJoinRecord.ZoningApproval equals jurisdiction.DepartmentCode
                                        into jurisdictionJoin
                                        from jurisdictionRecord in jurisdictionJoin.DefaultIfEmpty()
                                        where bldgpermit.Id == id
                                        select new
                                        {
                                            bldgpermit = bldgpermit,
                                            cityJoinRecord = cityJoinRecord,
                                            jurisdictionRecord = jurisdictionRecord
                                        }).SingleOrDefault();
                    query.SetCityApproval(
                        BuildingPermitSystemMapper.MapToCityApproval(cityApproval.bldgpermit, cityApproval.cityJoinRecord, cityApproval.jurisdictionRecord));
                }
            }

            return query;
        }

        public BuildingPermitSystemBasicInfo GetBasicInfo(int id)
        {
            var query = (from bldgpermit in _context.BldgpermitApplicationMaster
                         join juri in _context.Bldgjurisdictions on bldgpermit.JurisdictionCode equals juri.DepartmentCode
                         join dept in _context.Bldgdepartments on bldgpermit.DepartmentCode equals dept.DepartmentCode
                         where bldgpermit.Id == id
                         select new { bldgpermit, juri, dept }).SingleOrDefault();

            return BuildingPermitSystemMapper.MapToBasicInfo(query.bldgpermit, query.juri, query.dept);
        }

        public DemolitionPermit GetDemolitionPermitByBuildingPermitSystemId(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join permit in _context.BldgdemolitionPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber }
                         join bldgFire in _context.BldgfireDistrictCodes on permit.FireDistrictCode equals bldgFire.FireDistrictCode
                         join bldgCondition in _context.BldgapplicationConditions
                         on new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber } equals new { bldgCondition.ApplicationYear, bldgCondition.ApplicationNumber, bldgCondition.AddendumNumber }
                         into bldgConditionJoin
                         from bldgConditionRecord in bldgConditionJoin.DefaultIfEmpty()
                         join bldgInspection in _context.BldgapplicationInspections
                         on new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber } equals new { bldgInspection.ApplicationYear, bldgInspection.ApplicationNumber, bldgInspection.AddendumNumber }
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
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { apcn.ApplicationYear, apcn.ApplicationNumber, apcn.AddendumNumber }
                         into apcnConditionJoin
                         from apcnConditionRecord in apcnConditionJoin.DefaultIfEmpty()
                         join apin in _context.BldgapplicationInspections
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { apin.ApplicationYear, apin.ApplicationNumber, apin.AddendumNumber }
                         into apinConditionJoin
                         from apinConditionRecord in apinConditionJoin.DefaultIfEmpty()
                         join appv in _context.BldgapplicationValues
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { appv.ApplicationYear, appv.ApplicationNumber, appv.AddendumNumber }
                         into appvCondition
                         from appvConditionRecord in appvCondition.DefaultIfEmpty()
                         join othd in _context.BldgotherPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { othd.ApplicationYear, othd.ApplicationNumber, othd.AddendumNumber }
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
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { mecd.ApplicationYear, mecd.ApplicationNumber, mecd.AddendumNumber }
                         join fdst in _context.BldgfireDistrictCodes
                         on mecd.FireDistrictCode equals fdst.FireDistrictCode
                         join apcn in _context.BldgapplicationConditions
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { apcn.ApplicationYear, apcn.ApplicationNumber, apcn.AddendumNumber }
                         into apcnConditionJoin
                         from apcnConditionRecord in apcnConditionJoin.DefaultIfEmpty()
                         join apin in _context.BldgapplicationInspections
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { apin.ApplicationYear, apin.ApplicationNumber, apin.AddendumNumber }
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
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { strd.ApplicationYear, strd.ApplicationNumber, strd.AddendumNumber }
                         join fdst in _context.BldgfireDistrictCodes
                         on strd.FireDistrictCode equals fdst.FireDistrictCode
                         join apcn in _context.BldgapplicationConditions
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { apcn.ApplicationYear, apcn.ApplicationNumber, apcn.AddendumNumber }
                         into apcnConditionJoin
                         from apcnConditionRecord in apcnConditionJoin.DefaultIfEmpty()
                         join apin in _context.BldgapplicationInspections
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { apin.ApplicationYear, apin.ApplicationNumber, apin.AddendumNumber }
                         into apinConditionJoin
                         from apinConditionRecord in apinConditionJoin.DefaultIfEmpty()
                         join appv in _context.BldgapplicationValues
                         on new { strd.ApplicationYear, strd.ApplicationNumber, strd.AddendumNumber } equals new { appv.ApplicationYear, appv.ApplicationNumber, appv.AddendumNumber }
                         into appvApplicationValues
                         from appvApplicationRecord in appvApplicationValues.DefaultIfEmpty()
                         where bldg.Id == id
                         select new { bldg, apcnConditionRecord, apinConditionRecord, strd, fdst, appvApplicationValues });

            if (query != null)
            {
                return PermitDetailMapper.Map(query.FirstOrDefault().bldg, query.FirstOrDefault().apcnConditionRecord,
                                              query.FirstOrDefault().apinConditionRecord, query.FirstOrDefault().strd, query.FirstOrDefault().fdst,
                                              query.SelectMany(t => t.appvApplicationValues).Distinct());
            }
            return null;
        }

        public GradingExcavationPermitDetail GetGradingExcavationPermitDetail(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join grdd in _context.BldggradingExcavatingPermitDetail
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { grdd.ApplicationYear, grdd.ApplicationNumber, grdd.AddendumNumber }
                         join fdst in _context.BldgfireDistrictCodes
                         on grdd.FireDistrictCode equals fdst.FireDistrictCode
                         join apcn in _context.BldgapplicationConditions
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { apcn.ApplicationYear, apcn.ApplicationNumber, apcn.AddendumNumber }
                         into apcnConditionJoin
                         from apcnConditionRecord in apcnConditionJoin.DefaultIfEmpty()
                         join apin in _context.BldgapplicationInspections
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { apin.ApplicationYear, apin.ApplicationNumber, apin.AddendumNumber }
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
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber }
                         join bldgFire in _context.BldgfireDistrictCodes on permit.FireDistrictCode equals bldgFire.FireDistrictCode
                         join bldgCondition in _context.BldgapplicationConditions
                         on new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber } equals new { bldgCondition.ApplicationYear, bldgCondition.ApplicationNumber, bldgCondition.AddendumNumber }
                         into bldgConditionJoin
                         from bldgConditionRecord in bldgConditionJoin.DefaultIfEmpty()
                         join bldgInspection in _context.BldgapplicationInspections
                         on new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber } equals new { bldgInspection.ApplicationYear, bldgInspection.ApplicationNumber, bldgInspection.AddendumNumber }
                         into bldgInspectionJoin
                         from bldgInspectionRecord in bldgInspectionJoin.DefaultIfEmpty()
                         join bldgValue in _context.BldgapplicationValues
                         on new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber } equals new { bldgValue.ApplicationYear, bldgValue.ApplicationNumber, bldgValue.AddendumNumber }
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
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber }
                         join bldgFire in _context.BldgfireDistrictCodes on permit.FireDistrictCode equals bldgFire.FireDistrictCode
                         join bldgCondition in _context.BldgapplicationConditions
                         on new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber } equals new { bldgCondition.ApplicationYear, bldgCondition.ApplicationNumber, bldgCondition.AddendumNumber }
                         into bldgConditionJoin
                         from bldgConditionRecord in bldgConditionJoin.DefaultIfEmpty()
                         join bldgInspection in _context.BldgapplicationInspections
                         on new { permit.ApplicationYear, permit.ApplicationNumber, permit.AddendumNumber } equals new { bldgInspection.ApplicationYear, bldgInspection.ApplicationNumber, bldgInspection.AddendumNumber }
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

        public ValuationAndFees GetValuationAndFees(int id, decimal? applicationYear, decimal? applicationNumber, string feeCode = null)
        {
            var query = (from appf in _context.BldgapplicationFees
                         join bldg in _context.BldgpermitApplicationMaster
                         on new { appf.ApplicationYear, appf.ApplicationNumber, appf.AddendumNumber } equals new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber }
                         join appv in _context.BldgapplicationValues
                         on new { appf.ApplicationYear, appf.ApplicationNumber, appf.AddendumNumber } equals new { appv.ApplicationYear, appv.ApplicationNumber, appv.AddendumNumber }
                         into appvJoin
                         from appvDetail in appvJoin.DefaultIfEmpty()
                         where bldg.Id == id &&
                               bldg.ApplicationYear == applicationYear &&
                               bldg.ApplicationNumber == applicationNumber
                         select new ValuationAndFeesRecord { Appv = appvDetail, Appf = appf, Bldg = bldg }).ToList();

            return ValuationAndFeesMapper.Map(query, feeCode);
        }

        public ValuationFeeDetails GetValuationDetails(int id)
        {
            var query = (from bldg in _context.BldgpermitApplicationMaster
                         join appv in _context.BldgapplicationValues
                         on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { appv.ApplicationYear, appv.ApplicationNumber, appv.AddendumNumber }
                         into appvJoin
                         from appvDetail in appvJoin.DefaultIfEmpty()
                         where bldg.Id == id
                         select appvDetail).ToList();

            return ValuationAndFeesMapper.Map(query);
        }

        public IEnumerable<BuildingInspection> GetInspectionsByBuildingPermitSystemId(int id)
        {
            var inspections = (from bldg in _context.BldgpermitApplicationMaster
                               join bldgInspection in _context.BldgapplicationInspections
                               on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { bldgInspection.ApplicationYear, bldgInspection.ApplicationNumber, bldgInspection.AddendumNumber }
                               where bldg.Id == id
                               select BuildingInspectionMapper.Map(bldgInspection)).ToList();

            return inspections;
        }

        public IEnumerable<BuildingCondition> GetConditionsByBuildingPermitSystemId(int id)
        {
            var conditions = (from bldg in _context.BldgpermitApplicationMaster
                              join bldgCondition in _context.BldgapplicationConditions
                              on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { bldgCondition.ApplicationYear, bldgCondition.ApplicationNumber, bldgCondition.AddendumNumber }
                              where bldg.Id == id
                              select BuildingConditionMapper.Map(bldgCondition)).ToList();

            return conditions;
        }

        public (IEnumerable<ReceiptHeader> ReceiptHeaders, IEnumerable<BuildingApplicationFee> BuildingApplicationFees)
            GetReceiptHeadersAndFeesByBuildingPermitSystemId(int id)
        {
            var receipts = (from bldg in _context.BldgpermitApplicationMaster
                            join receipt in _context.BldgapplcationReceiptHeader
                            on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { receipt.ApplicationYear, receipt.ApplicationNumber, receipt.AddendumNumber }
                            join receiptDetailRecord in _context.BldgapplcationReceiptDetail
                            on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { receiptDetailRecord.ApplicationYear, receiptDetailRecord.ApplicationNumber, receiptDetailRecord.AddendumNumber }
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
                        on new { bldg.ApplicationYear, bldg.ApplicationNumber, bldg.AddendumNumber } equals new { fee.ApplicationYear, fee.ApplicationNumber, fee.AddendumNumber }
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