using System;
using System.Collections.Generic;
using System.Text;

namespace CMMI.Models
{
    public class User : EntityBase
    {
        public string UserName { get; set; }
        public int MyProperty { get; set; }
        public AuthLevel UserLevel { get; set; }
    }

    public enum AuthLevel
    {
        Admin = 1,
        Plain = 2
    }
}
