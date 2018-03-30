using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class Attendance
    {
        public int AttendaceId { get; set; }
        public int? StudentId { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public string AttendaceState { get; set; }
    }
}
