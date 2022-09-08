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
    public class CustomerManager : IGenericService<Customer>
    {
       ICustomerDal _custormerdal;

        public CustomerManager(ICustomerDal custormerdal)
        {
            _custormerdal = custormerdal;
        }

        public List<Customer> GetCustomerListWithJob()
        {
            return _custormerdal.GetListWithJob();
        }

        public void TDelete(Customer t)
        {
            _custormerdal.Delete(t);
        }

        public Customer TGetByID(int id)
        {
            return _custormerdal.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return _custormerdal.GetList();
        }

        public void TInsert(Customer t)
        {
            _custormerdal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _custormerdal.Update(t);
        }
    }
}
