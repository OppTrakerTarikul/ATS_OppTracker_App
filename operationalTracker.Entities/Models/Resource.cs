using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class Resource
    {
        public Resource()
        {
            ResourceAssignmentMap = new HashSet<ResourceAssignmentMap>();
        }

        public int RowId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int? ResourceRateId { get; set; }
        public string ResourceLocationType { get; set; }
        public string ResourceTechnologyGroup { get; set; }
        public string ResourceServiceLine { get; set; }
        public string ResourceOrgRole { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public ICollection<ResourceAssignmentMap> ResourceAssignmentMap { get; set; }
    }
}
