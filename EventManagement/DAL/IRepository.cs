using System;
using System.Collections.Generic;

namespace EventManagement.DAL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id );
    }
}
