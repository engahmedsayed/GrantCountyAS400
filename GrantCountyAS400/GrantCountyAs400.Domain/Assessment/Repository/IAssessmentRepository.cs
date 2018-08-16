using System.Collections.Generic;

namespace GrantCountyAs400.Domain.Assessment.Repository
{
    public interface IAssessmentRepository
    {
        IEnumerable<Assessment> GetAll(decimal parcelNumber, string taxpayer, string owner, string contractHolder, decimal taxcodeArea,
                                       string taxcodeDesc, out int resultCount, int pageNumber = 1, int pageSize = 50);

        AssessmentDetails Details(int id);
    }
}