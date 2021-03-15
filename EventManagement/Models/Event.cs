using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public string Organizer { get; set; }
        [ForeignKey("Location")]
        public int? LocationId { get; set; }
        public string BriefDescription { get; set; }
        public DateTime? Datetime { get; set; }
        public bool Status { get; set; }
        public Location Location { get; set; }
        public Category Category { get; set; }
    }
}
