using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe_Manager.Models;

public class Recipe
{
    // id for each recipe
    public int Id { get; set; }
    
    // name of the dish
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Dish { get; set; }
    
    // list of ingredients
    [Required]
    public List<Ingredients>? Ingredients { get; set; }

    // list of instructions
    [Required]
    public List<string>? Instructions { get; set; }
}
