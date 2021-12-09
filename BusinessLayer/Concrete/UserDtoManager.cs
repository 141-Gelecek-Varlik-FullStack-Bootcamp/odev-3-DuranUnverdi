using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
  public  class UserDtoManager : IUserDtoService
    {
        IUserDtoDal _userdtoDal;

        public UserDtoManager(IUserDtoDal userdtoDal)
        {
            _userdtoDal = userdtoDal;
        }

        public List<UserDto> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(UserDto t)
        {
            _userdtoDal.Insert(t);
        }

        public void TDelete(UserDto t)
        {
            throw new NotImplementedException();
        }

        public UserDto TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserDto t)
        {
            throw new NotImplementedException();
        }
    }
}
