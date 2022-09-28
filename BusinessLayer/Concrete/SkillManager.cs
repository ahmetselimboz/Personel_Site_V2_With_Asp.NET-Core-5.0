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
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Delete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public Skill GetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> GetListAll()
        {
            return _skillDal.GetListAll();
        }

        public void Insert(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void Update(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
