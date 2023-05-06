using BlazorBlog.Shared.Models;

using Microsoft.EntityFrameworkCore;

namespace BlazorBlog.Server.Data;

public class BlogsContext:DbContext
{
    public BlogsContext(DbContextOptions<BlogsContext> options) : base(options)
    {
        
    }
    public DbSet<BlogPost> BlogPosts { get; set; }
}
