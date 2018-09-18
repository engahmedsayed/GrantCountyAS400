using System;
using System.Collections.Generic;
using System.Text;

namespace GrantCountyAs400.Domain.Building
{
    public class BuildingPermitSystemDetail
    {
       

        public BuildingPermitSystemDetail(string jurisdictionCode, string departmentCode, decimal? applicationYear, 
                                          decimal? addendumNumber, string permitStatus, string applicationName,
                                          string contractLicenseNumber, string applicantProjectDescription,
                                          string additionalInformation, string resultOfEnforcementAction, 
                                          string enforcementDescription, string plotPlanReceived, 
                                          string onlyStructureOnParcel,string onlyResidenceOnParcel)
        {
            this.JurisdictionCode = jurisdictionCode;
            this.DepartmentCode = departmentCode;
            this.ApplicationYear = applicationYear;
            this.AddendumNumber = addendumNumber;
            this.PermitStatus = permitStatus;
            this.ApplicationName = applicationName;
            this.ContractLicenseNumber = contractLicenseNumber;
            this.ApplicantProjectDescription = applicantProjectDescription;
            this.AdditionalInformation = additionalInformation;
            this.ResultOfEnforcementAction = resultOfEnforcementAction;
            this.EnforcementDescription = enforcementDescription;
            this.PlotPlanReceived = plotPlanReceived;
            this.OnlyStructureOnParcel = onlyStructureOnParcel;
            this.OnlyResidenceOnParcel = onlyResidenceOnParcel;
        }

        public string JurisdictionCode { get; private set; }
        public string DepartmentCode { get; private set; }
        public decimal? ApplicationYear { get;private set; }
        public decimal? AddendumNumber { get; private set; }
        public string PermitStatus { get; private set; }
        public string ApplicationName { get; private set; }
        public string ContractLicenseNumber { get; private set; }
        public string ApplicantProjectDescription { get; private set; }
        public string AdditionalInformation { get; private set; }
        public string ResultOfEnforcementAction { get; private set; }
        public string EnforcementDescription { get; private set; }
        public string PlotPlanReceived { get; private set; }
        public string OnlyStructureOnParcel { get; private set; }
        public string OnlyResidenceOnParcel { get; private set; }
    }
}
