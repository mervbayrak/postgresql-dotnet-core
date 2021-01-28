using PostgreSql.Core.DataAccess.EntityFramework;
using PostgreSql.DAL.Abstract;
using PostgreSql.DAL.Concrete.EntityFramework.Context;
using PostgreSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.DAL.Concrete.EntityFramework.Management
{
    public class EFUserDAL : EFEntityRepositoryBase<MyDBContext, User>, IUserDAL
    {
    }
}
