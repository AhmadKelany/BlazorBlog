using BlazorBlog.Shared.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBlog.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogsController : ControllerBase
{
    List<BlogPost> posts = new()
    {
        new() {Id = 1 ,Url = "ostrich-eggs" , Author = "Hamoksha" , Content = "Dolore ut ipsum tempor commodo vero erat lorem aliquip dolores. Nihil invidunt duo justo et diam labore. Magna eum ut ut labore erat tation sadipscing odio amet molestie facilisis luptatum sanctus adipiscing tempor. Ut duo dolor sea ipsum sit gubergren ipsum erat in amet eleifend. Ut labore nonumy at eos tempor ipsum illum duo vero tempor aliquyam takimata ipsum duo no amet elitr. Minim vel et et et lorem nostrud sadipscing quod. Et et diam sadipscing aliquip ipsum tempor eirmod elitr et autem ut vero vero consetetur delenit diam dolor ipsum. Exerci aliquyam vel gubergren labore lobortis molestie sanctus duo accusam sed sadipscing sit. Diam iusto dolore eirmod et amet autem eirmod sea in at amet tation. Sed invidunt et labore nonumy sit nonumy sadipscing labore et sea sadipscing duo voluptua ipsum. Sanctus aliquip et. Diam facer justo diam in takimata iriure tincidunt et sea. Vel amet sed. Amet erat vel lorem amet gubergren possim ipsum sed erat illum diam. Ea eirmod molestie aliquyam rebum stet dolore vero est esse rebum." , DateCreated = new(2023,4,1) , Description = "I told you, AMAZING stuffs!" , IsDeleted = false , IsPublished = true, Title = "API Thermo-Nuclear Boiling of Ostrich Eggs"} ,
        new() {Id = 2 ,Url = "construction-words" , Author = "Xeroqil" , Content = "Wonderful Stuff, Ut eum ea dolore amet nonumy nonumy eos kasd velit eirmod aliquyam. Facilisis eirmod sed sed consectetuer et amet lorem duis et in nobis facilisis. Eos eos stet ipsum et delenit lorem at duo vero consetetur. No sanctus adipiscing invidunt ut et lobortis est. Ipsum at quod dolor. Et hendrerit placerat vero takimata sed elitr et. Lorem magna dolor takimata labore. Eos velit sit. Vero rebum sed gubergren nibh nonumy." , DateCreated = new(2023,4,15) , Description = "I informed you, Wonderful stuff!" , IsDeleted = false , IsPublished = true, Title = "API Reconstruction of deconstructed words"} ,
    };

    [HttpGet]
    public ActionResult<List<BlogPost>> GetAllPosts()
    {
        return Ok(posts);
    }

    [HttpGet("{url}")]
    public ActionResult<BlogPost> GetPostByUrl(string url)
    {
        BlogPost post = posts.FirstOrDefault(x => x.Url == url);
        return post != null ? Ok(post) : NotFound($"The post with url: {url} doesn't exist.");
    }

}
