using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailProject.Data.Entities
{
    internal class UserRoles
    {
            public int Id { set; get; }
            public int? UserId { get; set; }
            public int? RoleId { get; set; }
    }
}
