using System;
using EventManagement.DAL;
using EventManagement.Models;
using EventManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Location = EventManagement.ViewModels.Location;
using System.Collections.Generic;

namespace EventManagement.Controllers
{
    public class EventController: Controller
    {
        private readonly IRepository<Event> _eventRepository;
        private readonly IRepository<Models.Location> _locationRepository;
        private readonly IRepository<Models.Category> _categoryRepository;

        public EventController(IRepository<Event> eventRepository, IRepository<Models.Location> locationRepository, IRepository<Models.Category> categoryRepository)
        {
            _eventRepository = eventRepository;
            _locationRepository = locationRepository;
            _categoryRepository = categoryRepository;
        }
        #region View List
        public IActionResult Index(int? id)
        {
            var vm = new EventsViewModel();
            var events = _eventRepository.GetAll().ToList();
            var allevents = new List<EventListViewModel>();
            foreach (var ev in events)
            {
                var eventvm = new EventListViewModel();
                eventvm.EventId = ev.EventId;
                eventvm.Name = ev.Name;
                eventvm.City = _locationRepository.Get(ev.LocationId.GetValueOrDefault())?.City;
                eventvm.CategoryName = _categoryRepository.Get(ev.CategoryId.GetValueOrDefault())?.CategoryName;
                eventvm.Status = ev.Status == true ? "Active" : "InActive";
                eventvm.CategoryId = ev.CategoryId.GetValueOrDefault();
                allevents.Add(eventvm);

            }
            vm.AllEvents = allevents;

            vm.ActiveEvents = vm.AllEvents.Where(r => r.Status == "Active").ToList();
            if(id > 0)
            {
                vm.ActiveEvents = vm.ActiveEvents.Where(r => r.CategoryId == id).ToList();
            }
            ViewBag.ActiveHome = "Active";
            return View("~/Views/Home/Index.cshtml", vm);
        }
        #endregion

        #region AddEvent
        [HttpGet]
        public IActionResult AddEvent(int? id, string msg = null)
        {
            if (id == null || id == 0)

            {
                var ev = new EventViewModel();
                ev.Categories = _categoryRepository.GetAll().ToList().Select(x => new TextValue() { Text = x.CategoryName, Value = x.CategoryId }).ToList();
                if (msg != null)
                    ViewBag.DisplayMessage = msg;
                ViewBag.ActiveEvent = "Active";
                return View("~/Views/Event/AddEvent.cshtml", ev);


            }
            return View();
        }

        [HttpPost]
        public IActionResult Event(EventViewModel eViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!IsValidEvent(eViewModel))
                    {
                        ModelState.AddModelError("", "Same Event already exists for same organizer and category for same date");
                        eViewModel.Categories = _categoryRepository.GetAll().ToList().Select(x => new TextValue() { Text = x.CategoryName, Value = x.CategoryId }).ToList();
                        eViewModel. Statuslist = new List<TextValue>()
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
                        ViewBag.ActiveEvent = "Active";
                        return View("~/Views/Event/AddEvent.cshtml", eViewModel);
                    }
                    var location = MappedLocationViewModelToModel(eViewModel.Location);
                    var eventModel = MappedEventViewModelToModel(eViewModel);
                    eventModel.Location = location;
                    _eventRepository.Insert(eventModel);

                    return RedirectToAction("AddEvent", new { id = 0, msg = "Added Successfully" });

                }
            }
            catch (Exception)
            {
                //TODO add logger here
                
                return View("Error");
            }
           
            return View();
        }
        private Event MappedEventViewModelToModel(EventViewModel eventViewModel)
        {
            var eventModel = new Event();
            eventModel.EventId = eventViewModel.EventId;
            eventModel.Name = eventViewModel.Name;
            eventModel.CategoryId = eventViewModel.CategoryId;
            eventModel.Organizer = eventViewModel.Organizer;
            eventModel.LocationId = eventViewModel.LocationId;
            eventModel.BriefDescription = eventViewModel.BriefDescription;
            eventModel.Datetime = eventViewModel.Datetime;
            eventModel.Status = eventViewModel.Status == "Active" ? true : false;
            return eventModel;

        }

        private Models.Location MappedLocationViewModelToModel(ViewModels.Location locationViewModel)
        {
            var locationModel = new Models.Location();
            locationModel.LocId = locationViewModel.LocId;
            locationModel.Addressline1 = locationViewModel.Addressline1;
            locationModel.Line2 = locationViewModel.Line2;
            locationModel.City = locationViewModel.City;
            locationModel.State = locationViewModel.State;
            locationModel.ZipCode = locationViewModel.ZipCode;
            return locationModel;

        }

        private bool IsValidEvent(EventViewModel eventModel)
        {
            var evntModel = _eventRepository.GetAll().Where(x => x.CategoryId == eventModel.CategoryId && x.Organizer == eventModel.Organizer
            && x.Name == eventModel.Name && x.Datetime == eventModel.Datetime)?.SingleOrDefault();
            if (eventModel == null)
                return false;
            else
                return true;
        }
        #endregion

        #region Category
        public IActionResult Category()
        {
            //throw new Exception("this");
            var categories = _categoryRepository.GetAll().Select(x => new CategoryViewModel()
            {
                Id = x.CategoryId,
                CatName = x.CategoryName

            }).ToList();
            ViewBag.ActiveCategory = "Active";
            return View("~/Views/Event/Category.cshtml", categories);
           
        }



        #endregion

        #region EditEvent
        [HttpGet]
        public IActionResult EditEvent(int id, string msg = null)
        { 
             
                var ev = new EventViewModel();
                var emodel = _eventRepository.Get(id);
           
                ev.Categories = _categoryRepository.GetAll().ToList().Select(x => new TextValue() { Text = x.CategoryName, Value = x.CategoryId }).ToList();
                ev = MappedEventModelToViewModel(emodel, ev);
            if (emodel.LocationId > 0)
            {
                var locationmodel = _locationRepository.Get(emodel.LocationId.GetValueOrDefault());
                var locationViewModel = new Location();
                locationViewModel.LocId = locationmodel.LocId;
                locationViewModel.Addressline1 = locationmodel.Addressline1;
                locationViewModel.Line2 = locationmodel.Line2;
                locationViewModel.City = locationmodel.City;
                locationViewModel.State = locationmodel.State;
                locationViewModel.ZipCode = locationmodel.ZipCode;
                ev.Location = locationViewModel;
            }

                if (msg != null)
                    ViewBag.DisplayMessage = msg;
            ViewBag.ActiveHome = "Active";
            return View("~/Views/Event/EditEvent.cshtml", ev);


            
        }
        private EventViewModel MappedEventModelToViewModel(Event emodel, EventViewModel eventModel)
        {
            
            eventModel.EventId = emodel.EventId;
            eventModel.Name = emodel.Name;
            eventModel.CategoryId = emodel.CategoryId.GetValueOrDefault();
            eventModel.Organizer = emodel.Organizer;
            eventModel.LocationId = emodel.LocationId.GetValueOrDefault();
            eventModel.BriefDescription = emodel.BriefDescription;
            eventModel.Datetime = emodel.Datetime;
            eventModel.CategoryId = emodel.CategoryId.GetValueOrDefault();
            eventModel.LocationId = emodel.LocationId.GetValueOrDefault();
            eventModel.Status = emodel.Status ==true ? "Active" : "Inactive";
            return eventModel;

        }
        [HttpPost]
        public IActionResult EditEvent(EventViewModel eViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!IsValidEvent(eViewModel))
                    {
                        ModelState.AddModelError("", "Same Event already exists for same organizer and category for same date");
                        eViewModel.Categories = _categoryRepository.GetAll().ToList().Select(x => new TextValue() { Text = x.CategoryName, Value = x.CategoryId }).ToList();
                        eViewModel.Statuslist = new List<TextValue>()
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
                        ViewBag.ActiveEvent = "Active";
                        return View("~/Views/Event/EditEvent.cshtml", eViewModel);
                    }
                    
                    var location = MappedLocationViewModelToModel(eViewModel.Location);
                    var eventModel = MappedEventViewModelToModel(eViewModel);
                    eventModel.Location = location;
                    var evModel = _eventRepository.Update(eventModel);
                    return RedirectToAction("EditEvent", new { id = eViewModel.EventId, msg = "Updated successfully" });

                }
            }
            catch (Exception)
            {
                //TODO add logger here

                return View("Error");
            }

            return View();










        }
        #endregion

        #region DeleteEvent

        public IActionResult Delete(int id)
        {
            var edelete = _eventRepository.Get(id);
            edelete.CategoryId = null;
            _locationRepository.Delete(edelete.LocationId.GetValueOrDefault());
            _eventRepository.Delete(id);
            return RedirectToAction("Index");
        }

        #endregion

        #region ViewDetails
        [HttpGet]
        public IActionResult ViewDetails(int id)
        {


            var ev = new EventViewModel();
            var emodel = _eventRepository.Get(id);

            ev.Categories = _categoryRepository.GetAll().ToList().Select(x => new TextValue() { Text = x.CategoryName, Value = x.CategoryId }).ToList();
            ev = MappedEventModelToViewModel(emodel, ev);
            if (emodel.LocationId > 0)
            {
                var locationmodel = _locationRepository.Get(emodel.LocationId.GetValueOrDefault());
                var locationViewModel = new Location();
                locationViewModel.LocId = locationmodel.LocId;
                locationViewModel.Addressline1 = locationmodel.Addressline1;
                locationViewModel.Line2 = locationmodel.Line2;
                locationViewModel.City = locationmodel.City;
                locationViewModel.State = locationmodel.State;
                locationViewModel.ZipCode = locationmodel.ZipCode;
                ev.Location = locationViewModel;
            }
            ViewBag.ActiveHome = "Active";

            return View("~/Views/Event/ViewDetails.cshtml", ev);



        }
        #endregion

        #region Search
        
        public IActionResult SearchEvent(string searchText)
        {
            var searchViewModel =new SearchViewModel();
            var allevents = new List<EventListViewModel>();
            var events = _eventRepository.GetAll().ToList();
            foreach (var ev in events)
            {
                var eventvm = new EventListViewModel();
                eventvm.EventId = ev.EventId;
                eventvm.Name = ev.Name;
                eventvm.City = _locationRepository.Get(ev.LocationId.GetValueOrDefault())?.City;
                eventvm.CategoryName = _categoryRepository.Get(ev.CategoryId.GetValueOrDefault())?.CategoryName;
                eventvm.Status = ev.Status == true ? "Active" : "InActive";
                eventvm.CategoryId = ev.CategoryId.GetValueOrDefault();
                allevents.Add(eventvm);

            }
            if(string.IsNullOrEmpty(searchText))
            {
                searchViewModel.AllEvents = allevents;
            }
            else
            {
                var inputtxt= searchText.ToLower();
                searchViewModel.AllEvents = allevents.Where(x => x.Name.ToLower() == inputtxt).ToList();
            }
            searchViewModel.InputText = searchText;
            ViewBag.ActiveSearch = "Active";

            return View("~/Views/Event/SearchEvent.cshtml", searchViewModel);



        }


        public IActionResult Search(SearchViewModel eViewModel)
        {
            return RedirectToAction("SearchEvent", new { searchText = eViewModel.InputText });
        }
            #endregion

        }
}
