using ArtistSearch.Business.Entities;
using ArtistSearch.Business.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;


namespace ArtistSearch.Infrastructure
{
    public class ArtistService : IArtistService
    {
        private readonly IInfrastructureSettings _ingrastructureSettings;

        public ArtistService(IInfrastructureSettings ingrastructureSettings)
        {
            _ingrastructureSettings = ingrastructureSettings;
        }

        public Artist GetArtist(string artistName)
        {
            Artist artist = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_ingrastructureSettings.BandsintownUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var response = client.GetAsync($"/artists/{artistName}?app_id={_ingrastructureSettings.ProjectName}").Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    artist = JsonConvert.DeserializeObject<Artist>(content);
                }
            }
                       
            return artist;
        }

        public List<Event> GetArtistEvents(string artistName)
        {
            List<Event> events = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_ingrastructureSettings.BandsintownUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync($"/artists/{artistName}/events?app_id={_ingrastructureSettings.ProjectName}").Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    events = JsonConvert.DeserializeObject<List<Event>>(content);
                }
            }

            return events;
        }
    }
}
