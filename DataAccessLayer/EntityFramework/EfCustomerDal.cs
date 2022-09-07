using DataAccessLayer.Abstarct;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Cocrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericDal<Customer>, ICustomerDal
    {
        public List<Customer> GetListWithJob()
        {
            using(var c=new Context())
            {
                return c.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}
