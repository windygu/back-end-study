namespace ASP.NET.MVC.Migrations
{
    using ASP.NET.MVC.Areas.Restaurant.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASP.NET.MVC.Database.MVCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ASP.NET.MVC.Database.MVCDbContext";
        }

        protected override void Seed(ASP.NET.MVC.Database.MVCDbContext context)
        {
            var list = context.Restaurants.ToList();
            context.Restaurants.RemoveRange(list);
            context.SaveChanges();
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { City = "̨��", Country = "�й�", Name = "��������" },
                new Restaurant { City = "���", Country = "�й�", Name = "������Ѽ" },
                new Restaurant { City = "����", Country = "�й�", Name = "�ո�������" },
                new Restaurant
                {
                    City = "�人",
                    Country = "�й�",
                    Name = "�人�ȸ���",
                    Reviews = new List<RestaurantReview>
                    {
                        new RestaurantReview{ Rating=9,Body="�����ó�",RestaurantName="����"},
                        new RestaurantReview{ Rating=8,Body="�ܺó�",RestaurantName="С��"}
                    }
                },
                new Restaurant
                {
                    City = "�½�",
                    Country = "�й�",
                    Name = "ɳ��С��",
                    Reviews = new List<RestaurantReview>
                    {
                        new RestaurantReview{ Rating=9,Body="�����ó�",RestaurantName="С��"},
                        new RestaurantReview{ Rating=9,Body="�����ó�",RestaurantName="����"},
                    }
                }
                );

            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name, new Areas.Restaurant.Models.Restaurant
                {
                    City = "City" + i,
                    Country = "Contry" + i,
                    Name = "Name" + i,
                });
            }
        }
    }
}
