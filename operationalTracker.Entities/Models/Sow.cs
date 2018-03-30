using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class Sow
    {
        public Sow()
        {
            ResourceAssignmentMap = new HashSet<ResourceAssignmentMap>();
        }

        public int RowId { get; set; }
        public int SowId { get; set; }
        public int EsaId { get; set; }
        public string ProjectName { get; set; }
        public string SowStackHolder { get; set; }
        public string SowType { get; set; }
        public string SowProjectStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SowContactValue { get; set; }
        public string SowStatus { get; set; }
        public string SowPoNumber { get; set; }
        public DateTime? SubmitedDate { get; set; }
        public DateTime? PoDate { get; set; }
        public string SowComments { get; set; }
        public string OnsiteOwner { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public ICollection<ResourceAssignmentMap> ResourceAssignmentMap { get; set; }
    }
}
