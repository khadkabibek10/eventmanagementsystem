using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagement.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
