using System;
using System.Collections.Generic;

namespace EventManagement.ViewModels
{
    public class SearchViewModel
    {
        public SearchViewModel()
        {
            AllEvents = new List<EventListViewModel>();
            
        }
        public List<EventListViewModel> AllEvents { get; set; }
        public string InputText { get; set; }
      
    }
}
