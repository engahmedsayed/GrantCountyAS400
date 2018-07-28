using GrantCountyAs400.Domain.Assessment;
using GrantCountyAs400.PersistenceAdapter.Models;

namespace GrantCountyAs400.PersistenceAdapter.Mappers
{
    internal static class PlatCondoMapper
    {
        internal static PlatCondo Map(AsmtplatCondoMaster record) =>
            new PlatCondo(record.Id, record.PlatCode, record.PlatCodeType, record.PlatNameDesc, record.PlatDate, record.Township.Value,
                record.Range.Value, record.Section.Value, record.Volume.Value, record.Page.Value, record.FieldBook.Value, record.RevalutionPhase,
                record.AppraiserCode, record.HangerNumber, record.CommentLine1.Trim(), record.CommentLine2.Trim(), record.CommentLine3.Trim(),
                record.CommentLine4.Trim(), record.CommentLine5.Trim());
    }
}