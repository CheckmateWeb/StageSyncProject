using System.Data.Common;
using System.Data.Entity.Infrastructure;
using MySql.Data.EntityFramework;

namespace StageSync.Models.Context
{
   
    public class StageSyncMySqlConfiguration : MySqlEFConfiguration
    {
        public StageSyncMySqlConfiguration()
        {
            SetManifestTokenResolver(new FixedManifestTokenResolver());
        }
    }

    public class FixedManifestTokenResolver : IManifestTokenResolver
    {
        public string ResolveManifestToken(DbConnection connection)
        {
            return "5.7";
        }
    }
}
