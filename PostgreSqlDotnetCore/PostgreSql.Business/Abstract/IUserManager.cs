using PostgreSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.Business.Abstract
{
    public interface IUserManager
    {
        void Add(User u);
        void Update(User u);
        void Delete(User u);
        User GetById();
        List<User> GetList();
    }
}
