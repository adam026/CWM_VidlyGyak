using CWM_VidlyGyak.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CWM_VidlyGyak.DTOS
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        public int NumberInstock { get; set; }
        [Required]
        public byte GenreId { get; set; }

        public GenreDTO Genre { get; set; }
    }
}
