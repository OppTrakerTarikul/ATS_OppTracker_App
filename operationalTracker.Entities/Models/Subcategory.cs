using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class Subcategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
