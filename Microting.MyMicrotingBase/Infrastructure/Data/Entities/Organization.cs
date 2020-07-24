using Microting.eForm.Infrastructure.Constants;
using Microting.eFormApi.BasePn.Infrastructure.Database.Base;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Microting.MyMicrotingBase.Infrastructure.Data.Entities
{
    public class Organization: BaseEntity
    {
        public int CustomerId { get; set; }
        public string DomainName { get; set; }
        public string ServiceEmail { get; set; }
        public int NumberOfLicenses { get; set; }
        public int NumberOfLicensesUsed { get; set; }
        public string UpToDateStatus { get; set; }
        public DateTime NextUpgrade { get; set; }
        public string InstanceStatus { get; set; }
        public int InstanceId { get; set; }

        public async Task Create(MyMicrotingDbContext dbContext)
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            Version = 1;
            WorkflowState = Constants.WorkflowStates.Created;

            dbContext.Organizations.Add(this);
            await dbContext.SaveChangesAsync();

            dbContext.OrganizationVersions.Add(MapVersions(this));
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(MyMicrotingDbContext dbContext)
        {
            Organization organization = dbContext.Organizations.FirstOrDefault(x => x.Id == Id);

            if (organization == null)
            {
                throw new NullReferenceException($"Could not find Organization with {Id}");
            }

            organization.CustomerId = CustomerId;
            organization.DomainName = DomainName;
            organization.ServiceEmail = ServiceEmail;
            organization.NumberOfLicenses = NumberOfLicenses;
            organization.NumberOfLicensesUsed = NumberOfLicensesUsed;
            organization.UpToDateStatus = UpToDateStatus;
            organization.NextUpgrade = NextUpgrade;
            organization.InstanceStatus = InstanceStatus;
            organization.InstanceId = InstanceId;

            if (dbContext.ChangeTracker.HasChanges())
            {
                organization.UpdatedAt = DateTime.Now;
                organization.Version += 1;
                await dbContext.SaveChangesAsync();

                dbContext.OrganizationVersions.Add(MapVersions(organization));
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(MyMicrotingDbContext dbContext)
        {
            Organization organization = dbContext.Organizations.FirstOrDefault(x => x.Id == Id);

            if (organization == null)
            {
                throw new NullReferenceException($"Could not find Organization with {Id}");
            }

            organization.WorkflowState = Constants.WorkflowStates.Removed;

            if (dbContext.ChangeTracker.HasChanges())
            {
                organization.UpdatedAt = DateTime.Now;
                organization.Version += 1;
                await dbContext.SaveChangesAsync();

                dbContext.OrganizationVersions.Add(MapVersions(organization));
                await dbContext.SaveChangesAsync();
            }
        }

        private OrganizationVersion MapVersions(Organization organization)
        {
            return new OrganizationVersion
            {
                CustomerId = organization.CustomerId,
                DomainName = organization.DomainName,
                ServiceEmail = organization.ServiceEmail,
                NumberOfLicenses = organization.NumberOfLicenses,
                NumberOfLicensesUsed = organization.NumberOfLicensesUsed,
                UpToDateStatus = organization.UpToDateStatus,
                NextUpgrade = organization.NextUpgrade,
                InstanceStatus = organization.InstanceStatus,
                InstanceId = organization.InstanceId
            };
        }
    }
}
