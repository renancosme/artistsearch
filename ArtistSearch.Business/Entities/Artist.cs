using System.Collections.Generic;

namespace ArtistSearch.Business.Entities
{
    public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image_Url { get; set; }        

        public string Facebook_Page_Url { get; set; }

        public List<Event> Events { get; set; }
    }
}
