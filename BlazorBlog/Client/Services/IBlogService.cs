using BlazorBlog.Shared.Models;

namespace BlazorBlog.Client.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetBlogPosts();
        BlogPost GetBlogPostByUrl(string url);
    }
}
