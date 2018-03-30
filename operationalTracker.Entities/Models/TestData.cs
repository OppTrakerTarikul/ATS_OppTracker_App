using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class TestData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
    }
}
