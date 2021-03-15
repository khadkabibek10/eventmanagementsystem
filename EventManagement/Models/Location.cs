using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models
{
    public class Location
    {
        [Key]
        public int LocId { get; set; }
        public string Addressline1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCode { get; set; }
    }
}
