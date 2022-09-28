using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Delete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public Experience GetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<Experience> GetListAll()
        {
            return _experienceDal.GetListAll();
        }

        public void Insert(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void Update(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
