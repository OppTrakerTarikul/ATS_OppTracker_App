using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class TableRole
    {
        public int Rowid { get; set; }
        public int RoleId { get; set; }
        public string RoleDesc { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
