using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class Esa
    {
        public int RowId { get; set; }
        public int EsaProjectId { get; set; }
        public string EsaProjectName { get; set; }
        public string EsaProjectType { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
