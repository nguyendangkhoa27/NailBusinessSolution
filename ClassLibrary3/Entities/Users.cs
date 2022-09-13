using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailProject.Data.Entities
{
    internal class Users
    {
           public int Id { set; get; } 
           public string UserName { set; get; }
           public string Password { set; get; }
           public string PhoneNumber { set; get; }
           public string Email { set; get; }
           public DateTime DOB { set; get; }
           public string FullName { set; get; }
           public DateTime LastLoginDate { set; get; }
    }
}
