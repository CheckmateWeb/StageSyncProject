using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StageSync.Models.Tables;

namespace StageSync.Models.Maps
{
    public class TblCmsContentsMap : EntityTypeConfiguration<TblCmsContentsModel>
    {
        public TblCmsContentsMap()
        {
            HasKey(k => k.cmsID);
            ToTable("tbl_cms_contents");
        }
    }
}
