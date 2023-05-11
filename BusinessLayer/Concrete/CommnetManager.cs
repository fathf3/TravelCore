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
    public class CommnetManager : ICommentService
    {
        ICommentDal _CommentDal;

        public CommnetManager(ICommentDal commentDal)
        {
            _CommentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            _CommentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _CommentDal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _CommentDal.GetById(id);
        }

        public List<Comment> TGetDestinationID(int id)
        {
            return _CommentDal.GetListByFilter(x => x.DestinationID == id);
        }

        public List<Comment> TGetList()
        {
            return _CommentDal.GetList();
        }

        public List<Comment> TGetListWithDestination()
        {
            return _CommentDal.GetListCommentWithDestination();
        }

        public void TUpdate(Comment t)
        {
            _CommentDal.Update(t);
        }
    }
}
