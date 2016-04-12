namespace DevExpress.DemoData
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Core.Common;
    using System.Data.Entity.Core.EntityClient;
    using System.Data.Entity.Infrastructure;
    using System.Data.SQLite;
    using System.Data.SQLite.EF6;

    internal class DemoDbContextConfiguration : DbConfiguration
    {
        public DemoDbContextConfiguration()
        {
            if (!DemoDbContext.IsWebModel)
            {
                base.SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
                base.SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
                base.SetProviderServices("System.Data.SQLite", GetProviderServices());
                base.SetProviderFactoryResolver(new SQLiteProviderFactoryResolver());
            }
        }

        private static DbProviderServices GetProviderServices()
        {
            return (DbProviderServices) SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices));
        }

        private class SQLiteProviderFactoryResolver : IDbProviderFactoryResolver
        {
            DbProviderFactory IDbProviderFactoryResolver.ResolveProviderFactory(DbConnection connection)
            {
                if (connection is SQLiteConnection)
                {
                    return SQLiteFactory.Instance;
                }
                if (connection is EntityConnection)
                {
                    return EntityProviderFactory.Instance;
                }
                return null;
            }
        }
    }
}

