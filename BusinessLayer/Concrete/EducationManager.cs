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
    public class EducationManager : IEducationService
    {
        private readonly IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void Delete(Education t)
        {
            _educationDal.Delete(t);
        }

        public Education GetById(int id)
        {
            return _educationDal.GetById(id);
        }

        public List<Education> GetListAll()
        {
            return _educationDal.GetListAll();
        }

        public void Insert(Education t)
        {
            _educationDal.Insert(t);
        }

        public void Update(Education t)
        {
            _educationDal.Update(t);
        }
    }
}
