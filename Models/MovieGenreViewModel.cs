using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    // List of Movies
    public List<Movie>? Movies { get; set; }

    // List of genres. This allows the user to select a genre from the list.
    public SelectList? Genres { get; set; }

    // MovieGenre, which contains the selected genre.
    public string? MovieGenre { get; set; }

    // SearchString, which contains the text users enter in the search text box.
    public string? SearchString { get; set; }
}