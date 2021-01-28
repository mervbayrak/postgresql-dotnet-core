using PostgreSql.Business.Abstract;
using PostgreSql.Business.ValidationRules.FluentValidation;
using PostgreSql.Core.CrossCuttingConcers.FluentValidation;
using PostgreSql.DAL.Abstract;
using PostgreSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.Business.Concrete
{
    public class UserManager : IUserManager
    {
        private IUserDAL _userDAL;
        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public void Add(User u)
        {
            ValidationTool.FluentValidate(new UserValidator(), u);
            _userDAL.Add(u);
        }
        public void Update(User u)
        {
            _userDAL.Update(u);
        }
        public void Delete(User u)
        {
            _userDAL.Delete(u);
        }
        public User GetById()
        {
            return _userDAL.Get();
        }
        public List<User> GetList()
        {
            return _userDAL.GetList();
        }
    }
}
