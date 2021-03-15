using System;
using System.Collections.Generic;
using EventManagement.Models;

namespace EventManagement.DAL
{
    public class LocationRepository: IRepository<Location>
    {
        private readonly AppDbContext context;

        public LocationRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            Event e = context.Event.Find(id);
            if (e != null)
            {
                context.Event.Remove(e);
                context.SaveChanges();
            }
       
        }

        public Location Get(int id)
        {
            return context.Location.Find(id);
            
        }

        public IEnumerable<Location> GetAll()
        {
            throw new NotImplementedException();
        }

        public Location Insert(Location entity)
        {
            throw new NotImplementedException();
        }

        public Location Update(Location entity)
        {
            throw new NotImplementedException();
        }
    }
}
