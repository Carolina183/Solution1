using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.Domain.Entities.User
{
     public class ULoginData
     {
          public string Username { get; set; }
          public string Password { get; set; }

          public DateTime LoginDateTime { get; set; }
     }
}
