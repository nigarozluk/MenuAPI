using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.EFCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var scopeServices = app.ApplicationServices.CreateScope())
            {
                MenuContext context = scopeServices.ServiceProvider.GetRequiredService<MenuContext>();
                context.Database.Migrate();
                if (!context.Menus.Any())
                {
                    context.Menus.AddRange(
                        new Menu() { food1 = "Mercimek Çorbası", food2 = "Taze FaSulye, Su Böreği", food3 = "Semiz Otu Salatası", food4 = "Kemalpaşa Tatlısı" },
                        new Menu() { food1 = "Sebze Çorbası", food2 = "Etli Barbunya, Pirinç Pilavı", food3 = "Mevsim Salatası", food4 = "Sütlaç" },
                        new Menu() { food1 = "Domates Çorbası", food2 = "Tavuk Sote, BulgurPilavı", food3 = "Çoban Salatası", food4 = "İrmik Helvası" },
                        new Menu() { food1 = "Tavuk Çorbası", food2 = "Ispanak Yemeği, Makarna", food3 = "Havuç Tarator", food4 = "Kadayıf Dolması" },
                        new Menu() { food1 = "Yayla Çorbası", food2 = "Karnı Yarık, Şehriye Pilavı", food3 = "Pancar Salatası", food4 = "Güllaç" }


                        );
                    context.SaveChanges();
                }
            }


        }
    }
}
