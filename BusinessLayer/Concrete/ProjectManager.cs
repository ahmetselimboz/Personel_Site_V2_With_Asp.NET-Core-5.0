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
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Delete(Project t)
        {
            _projectDal.Delete(t);
        }

        public Project GetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public List<Project> GetListAll()
        {
            return _projectDal.GetListAll();
        }

        public void Insert(Project t)
        {
            _projectDal.Insert(t);
        }

        public void Update(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
