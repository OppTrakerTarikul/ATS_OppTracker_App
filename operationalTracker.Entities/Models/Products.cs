using System;
using System.Collections.Generic;

namespace operationalTracker.Entities.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? Price { get; set; }
        public string ImageUrl { get; set; }
        public int? SubcategoryId { get; set; }
    }
}
