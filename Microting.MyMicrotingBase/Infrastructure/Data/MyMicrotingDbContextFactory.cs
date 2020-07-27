using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Linq;

namespace Microting.MyMicrotingBase.Infrastructure.Data
{
    public class MyMicrotingDbContextFactory : IDesignTimeDbContextFactory<MyMicrotingDbContext>
    {
        public MyMicrotingDbContext CreateDbContext(string[] args)
        {
            var defaultCs = "Server = localhost; port = 3306; Database = mymicrotingbase; user = root; Convert Zero Datetime = true;";
            var optionsBuilder = new DbContextOptionsBuilder<MyMicrotingDbContext>();
            optionsBuilder.UseMySql(args.Any() ? args[0] : defaultCs);

            return new MyMicrotingDbContext(optionsBuilder.Options);
        }
    }
}
