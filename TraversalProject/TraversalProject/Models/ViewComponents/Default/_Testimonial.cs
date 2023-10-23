using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestomonialManager testomonialManager = new TestomonialManager(new EfTestiminoalDal());
        public IViewComponentResult Invoke()
        {
            var values = testomonialManager.TGetList();
            return View(values);
        }
    }
}
