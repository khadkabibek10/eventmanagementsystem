using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EventManagement.Models;

namespace EventManagement.ViewModels
{
    public class EventViewModel
    {
        public EventViewModel()
        {
            Location = new Location();
            
            Statuslist = new List<TextValue>()
             {
                  new TextValue()
                {
                    Text= "Active",
                    Value= 1
                },
                   new TextValue()
                {
                    Text= "Inactive",
                    Value= 2
                },
             };
        }
        public int EventId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="Name length cannot be more than 100")]
        public string Name { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public string Organizer { get; set; }
        public int LocationId { get; set; }
        public string BriefDescription { get; set; }
        public DateTime? Datetime { get; set; }
        public string Status { get; set; }

      
        public int CatId { get; set; }
        public string CategoryName { get; set; }

        public Location Location { get; set; }
        public List<TextValue> Categories { get; set; }
        public List<TextValue> Statuslist{ get; set; }


    }
    public class Location
    {
        public int LocId { get; set; }
        public string Addressline1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [RegularExpression(@"\d{5}$", ErrorMessage = "Invalid zip code")]
        public int? ZipCode { get; set; }


    }


    public class TextValue
    { 
        public int Value { get; set; }
        public string Text { get; set; }
    }
}
