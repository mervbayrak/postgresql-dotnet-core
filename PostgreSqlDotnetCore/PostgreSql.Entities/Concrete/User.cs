using PostgreSql.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSql.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
