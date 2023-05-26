using DataAccessLayer.Abstract;
using DataAccessLayer.Concrere;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
