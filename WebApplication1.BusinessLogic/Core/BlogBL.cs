using System.Collections.Generic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.Core
{
     public class BlogBL : BlogApi, IBlog
     {
          public PostEntity GetPostById(int id) => PostById(id);

          public List<PostEntity> GetAllPosts() => AllPosts();

          public bool TryEditPost(PostEntity post) => EditPost(post);

          public bool TryDeletePost(int id) => DeletePost(id);

          public bool TryAddPost(PostEntity post) => AddPost(post);

     }
}
