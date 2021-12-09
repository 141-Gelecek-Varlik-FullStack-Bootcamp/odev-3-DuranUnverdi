using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetList()
        {
            return _userDal.GetListAll();
        }

        public void TAdd(User t)
        {
            _userDal.Insert(t);
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public User TGetById(int id)
        {
           return _userDal.GetById(id);
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
