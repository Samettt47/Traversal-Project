using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Models.ViewComponents.Comments
{
    public class _CommentList : ViewComponent
    {
       
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.GetListCommentWithDestinationAndUser(id);
            
            int dataCount = context.Comments.Count(x=> x.DestinationId==id);
            ViewBag.dataCount = dataCount;
            return View(values);
        }

    }
}
