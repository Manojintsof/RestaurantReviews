using System;
using System.Collections.Generic;
using System.Text;

namespace CMMI.Models
{
    public class Restaurant : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public RestaurantType Type { get; set; }
    }

    public enum RestaurantType
    {
        Indian = 1,
        Maxican = 2,
        Continental = 3,
        American = 4
    }
}
