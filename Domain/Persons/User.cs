using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persons
{
    public class User
    {
        public string Name { get;}
        public UserRole UserRole { get;}
        public User (string name, UserRole userRole)
        {
            Name = name;
            UserRole = userRole;
        }

    }
}
