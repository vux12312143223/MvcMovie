using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }

    // List of genres for user to choose from
    public SelectList? Genres { get; set; }

    // Selected genre
    public string? MovieGenre { get; set; }

    // Search term
    public string? SearchString { get; set; }
}
