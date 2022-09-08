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
    public class JobManger :IGenericService<Job>
    {
        IJobDal _jobdal;

        public JobManger(IJobDal jobdal)
        {
            _jobdal = jobdal;
        }

        public void TDelete(Job t)
        {
            _jobdal.Delete(t);
        }

        public Job TGetByID(int id)
        {
            return _jobdal.GetByID(id);
        }

        public List<Job> TGetList()
        {
            return _jobdal.GetList();
        }

        public void TInsert(Job t)
        {
            _jobdal.Insert(t);
        }

        public void TUpdate(Job t)
        {
            _jobdal.Update(t);
        }
    }
}
