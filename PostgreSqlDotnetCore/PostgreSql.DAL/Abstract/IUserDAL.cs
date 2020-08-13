using PostgreSql.Core.DataAccess;
using PostgreSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.DAL.Abstract
{
    public interface IUserDAL : IEntityRepository<Users>
    {
    }
}
