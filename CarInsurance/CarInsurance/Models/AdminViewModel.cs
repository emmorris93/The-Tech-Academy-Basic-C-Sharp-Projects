using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class AdminViewModel
    {
        public decimal Quote { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
    }
}