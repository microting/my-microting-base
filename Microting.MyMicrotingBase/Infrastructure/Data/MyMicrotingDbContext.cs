using Microsoft.EntityFrameworkCore;
using Microting.eFormApi.BasePn.Abstractions;
using Microting.eFormApi.BasePn.Infrastructure.Database.Entities;
using Microting.MyMicrotingBase.Infrastructure.Data.Entities;

namespace Microting.MyMicrotingBase.Infrastructure.Data
{
    public class MyMicrotingDbContext : DbContext, IPluginDbContext
    {
        public MyMicrotingDbContext(DbContextOptions<MyMicrotingDbContext> options) : base(options)
        {

        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationVersion> OrganizationVersions { get; set; }
        public DbSet<PluginConfigurationValue> PluginConfigurationValues { get; set; }
        public DbSet<PluginConfigurationValueVersion> PluginConfigurationValueVersions { get; set; }
        public DbSet<PluginPermission> PluginPermissions { get; set; }
        public DbSet<PluginGroupPermission> PluginGroupPermissions { get; set; }
        public DbSet<PluginGroupPermissionVersion> PluginGroupPermissionVersions { get; set; }
    }
}
