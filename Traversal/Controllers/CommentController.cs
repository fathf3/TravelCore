using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommnetManager commnetManager = new CommnetManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentStat = true;
            commnetManager.TAdd(comment);
            return RedirectToAction("Index", "Destination");
        }
        
    }
}
