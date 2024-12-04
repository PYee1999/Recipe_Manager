using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Recipe_Manager.Models;

public class RecipeViewModel
{
    // List of Movies
    public List<Recipe>? Recipes { get; set; }

    // SearchString, which contains the text users enter in the search text box.
    public string? SearchString { get; set; }
}