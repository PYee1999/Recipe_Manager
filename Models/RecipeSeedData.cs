using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Recipe_Manager.Data;
using System;
using System.Linq;

namespace Recipe_Manager.Models;

public static class RecipeSeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcRecipeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcRecipeContext>>()))
        {
            // Look for any movies.
            if (context.Recipe.Any())
            {
                return;   // DB has been seeded
            }
            context.Recipe.AddRange(
                new Recipe
                {
                    Dish = "",
                    Ingredients = [
                        new Ingredients{
                            Quantity = 1,
                            Unit = "",
                            Ingredient = "Eggs",
                        },
                        new Ingredients{
                            Quantity = 1,
                            Unit = "tbsp",
                            Ingredient = "Honey",
                        }
                    ],
                    Instructions = [
                        "Beat and mix eggs",
                        "Add honey",
                        "Ready to serve",
                    ]
                }
            );
            context.SaveChanges();
        }
    }
}