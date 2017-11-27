using Microsoft.AspNetCore.Mvc;
using ArtistSearch.Presentation.Model;
using ArtistSearch.Business.Services;

namespace ArtistSearch.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArtistService _artistService;

        public HomeController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public IActionResult Index()
        {
            return View(new ArtistSearchModel());
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            if (ModelState.IsValid)
            {
                var artist = _artistService.GetArtist(name);
                artist.Events = _artistService.GetArtistEvents(name);
                return View(new ArtistSearchModel(artist));
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About the application";

            return View();
        }

        public IActionResult Contact()
        {            
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
