﻿using EntityLayer.Cocrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstarct
{
   public interface ICustomerDal:IGenericDal<Customer>
    {
        List<Customer> GetListWithJob();
    }
}
