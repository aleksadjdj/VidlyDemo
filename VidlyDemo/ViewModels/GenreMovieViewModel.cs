using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyDemo.Models;

namespace VidlyDemo.ViewModels
{
    public class GenreMovieViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }
        public Movie Movie { get; set; }
    }
}