using System;
using System.Collections.Generic;
using EventManagement.Models;

namespace EventManagement.DAL
{
    public class EventRepository: IRepository<Event>
    {
        private readonly AppDbContext context;

        public EventRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            Event book = context.Event.Find(id);
            if (book != null)
            {
                context.Event.Remove(book);
                context.SaveChanges();
            }
            
        }

        public Event Get(int id)
        {
            return context.Event.Find(id);
        }

        public IEnumerable<Event> GetAll()
        {
            return context.Event;
        }

        public Event Insert(Event e)
        {
            context.Event.Add(e);
            context.SaveChanges();
            return e;

        }

        public Event Update(Event e)
        {
            var book = context.Event.Attach(e);
            book.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return e;
        }
    }
}
