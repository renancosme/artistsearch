using ArtistSearch.Business.Services;

namespace ArtistSearch.Infrastructure
{
    public class InfrastructureSettings : IInfrastructureSettings
    {
        public string BandsintownUrl { get; }
        public string ProjectName { get; set; }

        public InfrastructureSettings(string bandsintownUrl, string projectName)
        {
            BandsintownUrl = bandsintownUrl;
            ProjectName = projectName;
        }
    }
}
