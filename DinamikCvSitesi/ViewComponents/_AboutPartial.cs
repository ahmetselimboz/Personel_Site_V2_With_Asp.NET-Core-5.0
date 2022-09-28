using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamikCvSitesi.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        CvContext c = new CvContext();
        private readonly IAboutService _aboutService;
       

        public _AboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var value = from s in c.SocialMedias
                        where s.SocialMediaID == 1
                        select new
                        {
                            link = s.LinkedinUrl,
                            insta =s.InstagramUrl,
                            twit =s.TwitterUrl,
                            Git =s.GithubUrl
                        };

            foreach (var item in value)
            {
                ViewBag.Linked = item.link;
                ViewBag.Insta = item.insta;
                ViewBag.twit = item.twit;
                ViewBag.Git = item.Git;
            }

            

            var values = _aboutService.GetListAll();
            return View(values);
        }
    }
}
