using DataAccessLayer.Abstract;
using DataAccessLayer.Concretre.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concretre.EntityFramework
{
    public class EfSkillDal : GenericRepository<Skill>, ISkillDal
    {
    }
}
