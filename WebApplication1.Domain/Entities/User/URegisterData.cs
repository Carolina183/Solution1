using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Entities.User
{
     public class URegisterData
     {
          public string Login { get; set; }
          public string Password { get; set; }
          public DateTime RegisterDate { get; set; }
     }
}
