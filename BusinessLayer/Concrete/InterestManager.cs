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
    public class InterestManager : IInterestService
    {
        private readonly IInterestDal _ınterestDal;

        public InterestManager(IInterestDal ınterestDal
            )
        {
            _ınterestDal = ınterestDal;
        }

        public void Delete(Interest t)
        {
            _ınterestDal.Delete(t);
        }

        public Interest GetById(int id)
        {
            return _ınterestDal.GetById(id);
        }

        public List<Interest> GetListAll()
        {
            return _ınterestDal.GetListAll();
        }

        public void Insert(Interest t)
        {
            _ınterestDal.Insert(t);
        }

        public void Update(Interest t)
        {
            _ınterestDal.Update(t);
        }
    }
}
