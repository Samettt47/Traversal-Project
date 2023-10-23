using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Controllers
{
    [AllowAnonymous]
    [Route("Comment")]
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        [Route("AddComment")]
        public IActionResult AddComment(Comment comment)
        {   
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            comment.CommentState = true;
            comment.CommentUser = TempData["userName"].ToString();
            commentManager.TAdd(comment);
            return RedirectToAction("DestinationDetails", "Destination" , new { id=comment.DestinationId });
        }
    }
}
