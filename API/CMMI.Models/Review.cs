using System;
using System.Collections.Generic;
using System.Text;

namespace CMMI.Models
{
    public class Review : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal StarRating { get; set; }
        public Restaurant Restaurant { get; set; }
        public User User { get; set; }
    }
}
