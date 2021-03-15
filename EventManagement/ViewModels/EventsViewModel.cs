using System;
using System.Collections.Generic;

namespace EventManagement.ViewModels
{
    public class EventsViewModel
    {
        public EventsViewModel()
        {
            AllEvents = new List<EventListViewModel>();
            ActiveEvents = new List<EventListViewModel>();
        }
        public List<EventListViewModel> AllEvents { get; set; }
        public List<EventListViewModel> ActiveEvents { get; set; }

    }
    public class EventListViewModel
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
    }
}
