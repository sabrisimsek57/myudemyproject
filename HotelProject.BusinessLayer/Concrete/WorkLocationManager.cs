using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccsessLayer.Abstract;
using HotelProject.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
   public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _testimonialDal;

        public WorkLocationManager(IWorkLocationDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(WorkLocation t)
        {
            _testimonialDal.Delete(t);
        }

        public WorkLocation TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<WorkLocation> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TInsert(WorkLocation t)
        {
            _testimonialDal.Insert(t);
        }

        public void TUpdate(WorkLocation t)
        {
            _testimonialDal.Update(t);
        }
    }
}
