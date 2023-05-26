using BusinessLayer.Abstract;
using DataAccessLayer.Concrere.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //BL amacı geçerlilik kontrollerini sağlamaktır.


    public class CategoryManager : ICategoryService
    {       
        EfCategoryRepository _efCategoryRepository;

        public CategoryManager(EfCategoryRepository efCategoryRepository)
        {
            _efCategoryRepository = efCategoryRepository;
        }

        public void CategoryAdd(Category category)
        {
            _efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _efCategoryRepository.Delete(category);
        }

        public void CategoryUpate(Category category)
        {
            _efCategoryRepository.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return _efCategoryRepository.GetListAll();
        }

        public Category GetCategoryById(int id)
        {
            return _efCategoryRepository.GetByID(id);
        }
    }
}
