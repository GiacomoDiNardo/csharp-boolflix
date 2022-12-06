using csharp_boolflix.Data;
using csharp_boolflix.Models;
using csharp_boolflix.Models.Forms;
using csharp_boolflix.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace csharp_boolflix.Controllers
{
    [Route("[controller]/[action]/{id?}", Order = 0)]
    public class FilmController : Controller
    {
        BoolflixDbContext db;

        IDbFilmRepository filmRepository;
        public FilmController(IDbFilmRepository _filmRepository, BoolflixDbContext _db) : base()
        {
            filmRepository = _filmRepository;
            db = _db;
        }

        public IActionResult Index()
        {
            List<Film> listaFilm = filmRepository.All();
            return View(listaFilm);
        }

        public IActionResult Create()
        {
            FilmForm formData = new FilmForm();

            formData.Casts = new List<SelectListItem>();
            List<Cast> castList = db.Casts.ToList();

            foreach (Cast cast in castList)
            {
                formData.Casts.Add(new SelectListItem(cast.Name, cast.Id.ToString()));
            }

            formData.Categories = new List<SelectListItem>();

            List<Category> categories = db.Categories.ToList();

            foreach (Category category in categories)
            {
                formData.Categories.Add(new SelectListItem(category.Name, category.Id.ToString()));
            }

            return View(formData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FilmForm formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Casts = new List<SelectListItem>();

                List<Cast> castList = db.Casts.ToList();

                foreach (Cast cast in castList)
                {
                    formData.Casts.Add(new SelectListItem(cast.Name, cast.Id.ToString()));
                }

                formData.Categories = new List<SelectListItem>();

                List<Category> categoryList = db.Categories.ToList();

                foreach (Category category in categoryList)
                {
                    formData.Categories.Add(new SelectListItem(category.Name, category.Id.ToString()));
                }

                return View(formData);
            }

            filmRepository.Create(formData.Film, formData.SelectedCast, formData.SelectedCategory);
            return RedirectToAction("Index");
        }
    }
}
