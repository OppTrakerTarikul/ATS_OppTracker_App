using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class ResourceAssignmentMap
    {
        public int RowId { get; set; }
        public int ResourceId { get; set; }
        public int SowId { get; set; }
        public bool? IsBillable { get; set; }
        public decimal? AllocationPercentage { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string Svp { get; set; }
        public string Vp { get; set; }
        public string Manager { get; set; }
        public int? EsaId { get; set; }
        public DateTime? EsaStartDate { get; set; }
        public DateTime? EsaEndDate { get; set; }

        public Resource Resource { get; set; }
        public Sow Sow { get; set; }
    }
}
