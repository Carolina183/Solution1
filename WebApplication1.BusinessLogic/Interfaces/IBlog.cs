using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.Interfaces
{
     public interface IBlog
     {
          PostEntity GetPostById(int id);
          List<PostEntity> GetAllPosts();
          bool TryAddPost(PostEntity post);
          bool TryEditPost(PostEntity post);
          bool TryDeletePost(int id);
     }
}
