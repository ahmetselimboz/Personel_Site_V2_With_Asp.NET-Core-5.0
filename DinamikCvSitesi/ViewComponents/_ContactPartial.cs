using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _ContactPartial : ViewComponent
    {
        


        public IViewComponentResult Invoke()
        {          
            return View();
        }

        

        
    }
}
