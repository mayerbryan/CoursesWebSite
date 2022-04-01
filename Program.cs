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
            articles.Add(new Article("Article about C#", "object-oriented"));
            articles.Add(new Article("Article about .NET", "object-oriented"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }


    }
}