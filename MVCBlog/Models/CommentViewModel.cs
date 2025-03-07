﻿using Microsoft.Ajax.Utilities;
using MVCBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MVCBlog.Models
{
    public class CommentViewModel
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public static Expression<Func<Comment,CommentViewModel>> ViewModel
        {
            get
            {
                return c => new CommentViewModel()
                {
                    Text=c.Text,
                    Author=c.Author.FullName
                };
            }
        }           
    }
}