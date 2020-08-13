using PostgreSql.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PostgreSql.Entities.Concrete
{
    public class Users : IEntity
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
