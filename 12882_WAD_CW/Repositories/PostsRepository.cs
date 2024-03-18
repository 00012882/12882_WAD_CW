using _12882_WAD_CW.Data;
using _12882_WAD_CW.Models;
using Microsoft.EntityFrameworkCore;

namespace _12882_WAD_CW.Repositories
{
    public class PostsRepository : IPostRepository
    {
        private readonly BlogDbContext _dbContext;

        public PostsRepository(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            var posts = await _dbContext.Posts.Include(p => p.User).ToListAsync();
            return posts;
        }

        public async Task<Post> GetPostById(int id)
        {
            return await _dbContext.Posts.Include(p => p.User).FirstOrDefaultAsync(p => p.PostID == id);
        }

        public async Task CreatePost(Post post)
        {
            await _dbContext.Posts.AddAsync(post);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePost(int id)
        {
            var post = await _dbContext.Posts.FirstOrDefaultAsync(p => p.PostID == id);
            if (post != null)
            {
                _dbContext.Posts.Remove(post);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdatePost(Post post)
        {
            _dbContext.Entry(post).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
