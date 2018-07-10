using AutoMapper;
using GrantCountyAs400.Domain.Accounting;
using GrantCountyAs400.Web.ViewModels.AccountingVM;

namespace GrantCountyAs400.Web
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                #region Accounting

                cfg.CreateMap<Personnel, PersonnelViewModel>();
                cfg.CreateMap<Contract, ContractViewModel>();
                cfg.CreateMap<Organization, OrganizationViewModel>();
                cfg.CreateMap<PersonnelWithContractFullDetails, PersonnelWithContractFullDetailsViewModel>();

                #endregion Accounting
            });
        }
    }
}