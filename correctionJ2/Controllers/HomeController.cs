using correctionJ2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace correctionJ2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return View("Error");
            }
            else
            {
                ViewData["Titre"] = id;
                return View();
            }
        }

        public IActionResult ListeFilms()
        {
            ViewData["Films"] = Films.ObtenirFilms();
            return View();
        }

        public IActionResult ChercheFilm(string id)
        {
            ViewData["Titre"] = id;
            Film film = Films.ObtenirFilms().FirstOrDefault(c => c.Titre == id); 
            if ((film != null) && (film.Visionne))
            {
                ViewData["Titre"] = film.Titre;
                ViewData["Année"] = film.Année;
                ViewData["Realisateur"] = film.Realisateur;
                ViewData["Visionne"] = film.Visionne;
                return View("Visionne");
            }
            else if ((film != null) && (!film.Visionne))
            {
                ViewData["Titre"] = film.Titre;
                ViewData["Visionne"] = film.Visionne;
                return View("AVisionner");
            }
            return View("NonVisionne");
        }
    }


}
