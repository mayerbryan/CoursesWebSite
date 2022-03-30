using System;
using System.Collections.Generic;
using System.Linq;
using CoursesWebSite.ContentContext;
using CoursesWebSite.SubscriptionContext;

namespace CoursesWebSite
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Article about OOP", "object-oriented"));
        }
    }
}