using System.Data.Entity;
using WebApplication1.Domain;

namespace WebApplication1.BusinessLogic
{
     class UserContext : DbContext
     {
          public UserContext() : base("name=WebApplication1")
          {
          }

          public virtual DbSet<User> Users { get; set; }
     }
}
