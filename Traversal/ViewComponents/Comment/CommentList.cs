using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        CommnetManager commnetManager = new CommnetManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commnetManager.TGetDestinationID(id);
            return View(values);
        }
    }
}
