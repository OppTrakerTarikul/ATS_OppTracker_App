using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class TableResource
    {
        public int Rowid { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public DateTime? ResourceStartDate { get; set; }
        public DateTime? ResourceEndDate { get; set; }
        public int? ResourceAccountRoleId { get; set; }
        public int? ResourceOrgRoleId { get; set; }
        public int? ResourcePracticeId { get; set; }
        public string ResourceLocationType { get; set; }
        public string ResourceLocationDesc { get; set; }
        public string ResourceAllocationPercentage { get; set; }
        public bool? ResourceIsbillable { get; set; }
        public string ResourceTechnologyGroup { get; set; }
        public string ResourceCoreTechnology { get; set; }
        public string ResourceApplicationGroup { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
