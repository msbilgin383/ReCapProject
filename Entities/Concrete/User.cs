using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User: IEntity
    {
        public int Id { get; set; }
        public long FirstName { get; set; }
        public long LastName { get; set; }
        public string Password { get; set; }
        public long Mail { get; set; }
    }
}
