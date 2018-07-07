namespace GrantCountyAs400.Web.ViewModels.AccountingVM
{
    public class OrganizationViewModel
    {
        public int Fund { get; set; }
        public int Department { get; set; }

        public string DisplayName => $"{Fund:D3}-{Department}";
    }
}