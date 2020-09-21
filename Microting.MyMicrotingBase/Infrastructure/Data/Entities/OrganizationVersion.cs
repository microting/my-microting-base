using Microting.eFormApi.BasePn.Infrastructure.Database.Base;
using System;

namespace Microting.MyMicrotingBase.Infrastructure.Data.Entities
{
    public class OrganizationVersion: BaseEntity
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
        public string Status { get; set; }
        public bool PaymentOverdue { get; set; }
        public string PaymentStatus { get; set; }
        public string CustomerNo { get; set; }
        public string Name { get; set; }
    }
}
