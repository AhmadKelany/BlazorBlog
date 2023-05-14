﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBlog.Shared.Models;

public class BlogPost
{
    public int Id { get; set; }
    public string Url { get; set; }
    [Required]
    public string Title { get; set; }
    public string Content { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public bool IsPublished { get; set; }
    public bool IsDeleted { get; set; }
}
