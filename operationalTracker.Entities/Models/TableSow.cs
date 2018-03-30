using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class TableSow
    {
        public int Rowid { get; set; }
        public int SowNumber { get; set; }
        public string SowDesc { get; set; }
        public DateTime? SowStartDate { get; set; }
        public DateTime? SowEndDate { get; set; }
        public string SowCustContactId { get; set; }
        public string SowOrgContactId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
