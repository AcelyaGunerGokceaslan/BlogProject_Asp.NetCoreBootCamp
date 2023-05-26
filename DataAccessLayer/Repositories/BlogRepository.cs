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
    public class BlogRepository : IBlogDal
    {
        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Blog GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
