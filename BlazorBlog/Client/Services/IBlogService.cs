using BlazorBlog.Shared.Models;

namespace BlazorBlog.Client.Services
{
    public interface IBlogService
    {
        Task<List<BlogPost>> GetBlogPostsAsync();
        Task<BlogPost> GetBlogPostByUrlAsync(string url);
        Task<BlogPost> CreateNewBlogPostAsync(BlogPost newPost);
    }
}
