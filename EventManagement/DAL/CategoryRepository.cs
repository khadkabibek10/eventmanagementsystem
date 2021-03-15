using System;
using System.Collections.Generic;
using EventManagement.Models;

namespace EventManagement.DAL
{
    public class CategoryRepository: IRepository<Category>
    {
        private readonly AppDbContext context;

        public CategoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            return context.Category.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return context.Category;
        }

        public Category Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
