namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface ILegalDocumentRepository
    {
        RealPropertyLegalDocument GetByParcelNumber(decimal parcelNumber);

        LegalDocumentDetails Details(int legalDocumentId);
    }
}