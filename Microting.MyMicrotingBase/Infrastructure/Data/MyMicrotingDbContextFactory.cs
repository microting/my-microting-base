using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Microting.MyMicrotingBase.Infrastructure.Data
{
    public class MyMicrotingDbContextFactory : IDesignTimeDbContextFactory<MyMicrotingDbContext>
    {
        public MyMicrotingDbContext CreateDbContext(string[] args)
        {
            var defaultCs = "Server = localhost; port = 3306; Database = mymicrotingbase; user = root; Convert Zero Datetime = true;";
            var optionsBuilder = new DbContextOptionsBuilder<MyMicrotingDbContext>();
            optionsBuilder.UseMySql(args.Any() ? args[0] : defaultCs, mysqlOptions =>
            {
                mysqlOptions.ServerVersion(new Version(10, 4, 0), ServerType.MariaDb).EnableRetryOnFailure();
            });

            return new MyMicrotingDbContext(optionsBuilder.Options);
            // dotnet ef migrations add InitialCreate --project Microting.MyMicrotingBase --startup-project DBMigrator
        }
    }
}
