using ArtistSearch.Business.Entities;
using System.Collections.Generic;

namespace ArtistSearch.Business.Services
{
    public interface IArtistService
    {
        Artist GetArtist(string artistName);
        List<Event> GetArtistEvents(string artistName);
    }
}
