using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeaturedManager : IFeaturedService
    {
        IFeaturedDal _featuredDal;

        public FeaturedManager(IFeaturedDal featuredDal)
        {
            _featuredDal = featuredDal;
        }

        public void TAdd(Featured t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Featured t)
        {
            throw new NotImplementedException();
        }

        public Featured TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Featured> TGetList()
        {
            return _featuredDal.GetList();
        }

        public void TUpdate(Featured t)
        {
            throw new NotImplementedException();
        }
    }
}
