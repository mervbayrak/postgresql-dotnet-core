using PostgreSql.Business.Abstract;
using PostgreSql.DAL.Abstract;
using PostgreSql.DAL.Concrete.EntityFramework.Management;
using PostgreSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.Business.Concrete
{
    public class UserManager : IUserManager
    {
        private IUserDAL _userDAL;
        public UserManager() : this(new EFUserDAL()) { }

        public UserManager(EFUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public void Add(Users u)
        {
            _userDAL.Add(u);
        }
        public void Update(Users u)
        {
            _userDAL.Update(u);
        }
        public void Delete(Users u)
        {
            _userDAL.Delete(u);
        }
        public Users GetById()
        {
            return _userDAL.Get();
        }
        public List<Users> GetList()
        {
            return _userDAL.GetList();
        }
    }
}
