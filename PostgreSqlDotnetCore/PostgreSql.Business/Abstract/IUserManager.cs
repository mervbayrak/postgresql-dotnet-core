using PostgreSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.Business.Abstract
{
    public interface IUserManager
    {
        void Add(Users u);
        void Update(Users u);
        void Delete(Users u);
        Users GetById();
        List<Users> GetList();
    }
}
