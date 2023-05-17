using BlazorBlog.Server.Data;
using BlazorBlog.Shared.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBlog.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogsController : ControllerBase
{
    BlogsContext _blogContext;
    public BlogsController(BlogsContext blogsContext)
    {
        _blogContext = blogsContext;
    }

    [HttpGet]
    public ActionResult<List<BlogPost>> GetAllPosts()
    {
        return Ok(_blogContext.BlogPosts);
    }

    [HttpGet("{url}")]
    public ActionResult<BlogPost> GetPostByUrl(string url)
    {
        BlogPost post = _blogContext.BlogPosts.FirstOrDefault(x => x.Url == url);
        return post != null ? Ok(post) : NotFound($"The post with url: {url} doesn't exist.");
    }

    [HttpPost]
    public async Task<ActionResult<BlogPost>> CreateNewBlogPost(BlogPost post)
    {
        _blogContext.BlogPosts.Add(post);
        await _blogContext.SaveChangesAsync();
        return Ok(post);
    }

}
