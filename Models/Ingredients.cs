using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe_Manager.Models;


public class Ingredients
{
    [Required]
    public int Quantity { get; set; }

    public string? Unit { get; set; }

    [Required]
    public string? Ingredient { get; set; }
}
