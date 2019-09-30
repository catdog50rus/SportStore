using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Каяк",
                        Description = "Лодка на одного человека",
                        Category = "Водный спорт",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Спасательный жилет",
                        Description = "Защитный и модный жилет",
                        Category = "Водный спорт",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Футбольный мяч",
                        Description = "Одобренн ФИФА по размеру и весу",
                        Category = "Футбол",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Угловые флаги",
                        Description = "Сделайте ваше игровое поле профессиональным",
                        Category = "Футбол",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Стадион",
                        Description = "Стадион на 35 000 мест",
                        Category = "Футбол",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Мыслящая шапка",
                        Description = "Улучшить эффективность мозга на 75%",
                        Category = "Шахматы",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Качающийся стул",
                        Description = "Тайно поставь противника в невыгодное положение",
                        Category = "Шахматы",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Шахматная доска",
                        Description = "Веселая игра для семьи",
                        Category = "Шахматы",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Блинг-Блинг Король",
                        Description = "Позолоченный, усыпанный бриллиантами король",
                        Category = "Шахматы",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
