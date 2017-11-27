using ArtistSearch.Business.Entities;
using System.ComponentModel.DataAnnotations;

namespace ArtistSearch.Presentation.Model
{
    public class ArtistSearchModel
    {
        public ArtistSearchModel() { }

        public ArtistSearchModel(Artist artist)
        {
            Artist = artist;
        }

        [Required(ErrorMessage = "The artist name is required.")]
        public string Name { get; set; }

        public Artist Artist { get; set; }
    }
}
