using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class ResourceRate
    {
        public int RowId { get; set; }
        public string Grade { get; set; }
        public decimal? Price { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
