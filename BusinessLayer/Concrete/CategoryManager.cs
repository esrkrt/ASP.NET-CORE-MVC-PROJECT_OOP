using BusinessLayer.Abstract;
using DataAccessLayer.Abstarct;
using EntityLayer.Cocrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {
        
       ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void TDelete(Category t)
        {
            _categorydal.Delete(t);
        }

        public Category TGetByID(int id)
        {
           return _categorydal.GetByID(id);
        }

        public List<Category> TGetList()
        {
          return _categorydal.GetList();
        }

        public void TInsert(Category t)
        {
            _categorydal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categorydal.Update(t);
        }
    }
}
