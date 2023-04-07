using PargatBooks.DataAccess.Repository.IRepository;
using PargatBooks.Models;
using PargatBookStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PargatBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;      // get the db instance using the constructor and DI 

        public CategoryRepository(ApplicationDbContext db) : base(db)    // use hot keys C-T-O-R to build the constructor
        {
            _db = db;

        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();

            }
        }
    }
}
