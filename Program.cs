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

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Aprenda OOP", "", null);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);


            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var payPalSubscription = new PayPalSubscription();
                var student = new Student();

                student.CreateSubscription(payPalSubscription);
            }


        }
    }
}