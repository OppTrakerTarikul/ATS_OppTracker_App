using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class Leave
    {
        public int RowId { get; set; }
        public int ResourceId { get; set; }
        public string LeaveType { get; set; }
        public string LeaveDesc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
