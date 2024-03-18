using _12882_WAD_CW.Models;

namespace _12882_WAD_CW.Repositories
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllPosts();
        Task<Post> GetPostById(int id);
        Task CreatePost(Post user);
        Task UpdatePost(Post user);
        Task DeletePost(int id);
    }
}
