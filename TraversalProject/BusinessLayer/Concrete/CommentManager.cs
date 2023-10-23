﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public Comment GetByID(int id)
        {
            return _commentDal.GetById(id);
        }

        public void TAdd(Comment t)
        {
             _commentDal.Insert(t);
        }
        public List<Comment> TGetDestinationByID(int id)
        {
            return _commentDal.GetListByFilter(x=> x.DestinationId == id);
        }

        public void TDelete(Comment t)
        {
             _commentDal.Delete(t);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();

        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
        }
    }
}
