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
    public class CertificationManager : ICertificationService
    {
        private readonly ICertificationDal _certificationDal;

        public CertificationManager(ICertificationDal certificationDal)
        {
            _certificationDal = certificationDal;
        }

        public void Delete(Certification t)
        {
            _certificationDal.Delete(t);
        }

        public Certification GetById(int id)
        {
            return _certificationDal.GetById(id);
        }

        public List<Certification> GetListAll()
        {
            return _certificationDal.GetListAll();
        }

        public void Insert(Certification t)
        {
            _certificationDal.Insert(t);
        }

        public void Update(Certification t)
        {
            _certificationDal.Update(t);
        }
    }
}
