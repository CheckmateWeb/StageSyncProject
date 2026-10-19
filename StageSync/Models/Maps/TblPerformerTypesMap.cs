using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblPerformerTypesMap : EntityTypeConfiguration<TblPerformerTypesModel>
    {
        public TblPerformerTypesMap()
        {
            HasKey(k => k.typeID);
            ToTable("tbl_performer_types");
        }
    }
}
