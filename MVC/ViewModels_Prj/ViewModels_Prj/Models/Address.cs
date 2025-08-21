using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModels_Prj.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string DoorNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}