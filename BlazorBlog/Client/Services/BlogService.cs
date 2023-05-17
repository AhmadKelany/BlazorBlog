using BlazorBlog.Shared.Models;

using System;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace BlazorBlog.Client.Services
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _httpClient;

        public BlogService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<BlogPost> CreateNewBlogPostAsync(BlogPost newPost)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/blogs",newPost); 
            BlogPost post = await result.Content.ReadFromJsonAsync<BlogPost>();
            return post;

        }



        public async Task<BlogPost> GetBlogPostByUrlAsync(string url)
        {

            HttpResponseMessage result = await _httpClient.GetAsync($"api/blogs/{url}");
            if (result.IsSuccessStatusCode)
            {
                BlogPost post = await _httpClient.GetFromJsonAsync<BlogPost>($"api/blogs/{url}");
                return post;
            }
            else
            {
                string msg = await result.Content.ReadAsStringAsync();
                Console.WriteLine(msg);
                return new BlogPost { Title = msg };
            }
        }

        public async Task<List<BlogPost>> GetBlogPostsAsync()
        {
            List < BlogPost > posts = await _httpClient.GetFromJsonAsync<List<BlogPost>>("api/blogs");
            return posts;
        }
    }
}
