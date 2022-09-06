using DataAccessLayer.Abstarct;
using DataAccessLayer.Repositories;
using EntityLayer.Cocrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
   public class EfJobDal : GenericDal<Job>, IJobDal
    {
    }
}
