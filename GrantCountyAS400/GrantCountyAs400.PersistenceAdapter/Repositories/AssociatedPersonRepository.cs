using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.Domain.Assessment.Repository;
using GrantCountyAs400.PersistenceAdapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantCountyAs400.PersistenceAdapter.Repositories
{
    public class AssociatedPersonRepository : IAssociatedPersonRepository
    {
        private readonly GrantCountyDbContext _context;

        public AssociatedPersonRepository(GrantCountyDbContext dbContext)
        {
            _context = dbContext;
        }
        public AssociatedPerson GetAssociatedPerson(decimal? parcelNumber, string nameCode)
        {

            var rpasc = _context.AsmtrealPropertyAssociatedPersons.Where(t => t.ParcelNumber == parcelNumber && 
                                                                         t.NameCode == nameCode).FirstOrDefault();
            var nnamejoinedRpasc = _context.AsmtmasterNameAddress.Where(t =>rpasc!=null && t.NameCode == rpasc.NameCode).FirstOrDefault();
            var rpmas = _context.AsmtrealPropertyAssessedValueMaster.Where(t => t.ParcelNumber == parcelNumber).FirstOrDefault();
            var taxPayerNName = _context.AsmtmasterNameAddress.Where(t => t.NameCode == rpmas.TaxpayerCode).FirstOrDefault();
            var ownerNName = _context.AsmtmasterNameAddress.Where(t => t.NameCode == rpmas.TaxpayerCode).FirstOrDefault();
            var aplnd = _context.AsmtlandUseCodes.Where(t => t.LandUseCode == rpmas.LandUseCode).FirstOrDefault();
            var rpzon = _context.AsmtzoneDescriptions.Where(t => t.ZoneCode == rpmas.ZoneCode).FirstOrDefault();
            var aptxc = _context.AsmttaxCodeArea.Where(t => t.TaxCodeArea == rpmas.TaxCodeArea).FirstOrDefault();
            if (rpasc != null )
            {
                var result = new AssociatedPerson(rpasc.Id, rpasc?.ParcelNumber, taxPayerNName?.Name, ownerNName?.Name, rpmas?.Description1,
                aplnd?.UseCodeShortDesc, rpmas?.Description2,rpmas?.Description3,rpmas?.Description4,rpmas?.Description5
                ,rpmas?.LienDate,rpmas?.AffidavitNumber,rpzon?.ZoneCodeDesc,aptxc?.TaxCodeDesc,rpmas?.FirePatrolAcres
                ,rpmas?.UnimprovedLandAcres,rpmas?.ImprovedLandAcers,rpmas?.FmimprovedLandValue,rpmas?.BuildingValue
                ,rpmas?.AffidavitTaxYear,rpasc?.NameCode,nnamejoinedRpasc?.NameCode,rpasc?.Comment, nnamejoinedRpasc?.AddressLine1
                , nnamejoinedRpasc?.City, nnamejoinedRpasc?.State, nnamejoinedRpasc?.Zip,rpasc?.ChangeId,rpasc?.ChangeDate);
                return result;
            }
            
            return null;
        }
    }
}
