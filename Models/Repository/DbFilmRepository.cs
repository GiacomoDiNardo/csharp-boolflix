using csharp_boolflix.Data;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Models.Repository
{
    public class DbFilmRepository : IDbFilmRepository
    {
        BoolflixDbContext db;
        public DbFilmRepository(BoolflixDbContext _db)
        {
            db = _db;
        }

        public List<Film> All()
        {
            return AllWithRelations();
        }

        private List<Film> AllWithRelations()
        {
            return db.Films.Include(f => f.Categories).Include(f => f.Casts).ToList();
        }

        public Film GetById(int id)
        {
            return db.Films.Where(f => f.Id == id).Include("Categories").Include("Casts").FirstOrDefault();
        }

        public void Create(Film film, List<int> selectedCast, List<int> selectedCategories)
        {
            
            film.Categories = new List<Category>();
            foreach (int categoryId in selectedCategories)
            {
                Category category = db.Categories.Where(c => c.Id == categoryId).FirstOrDefault();
                film.Categories.Add(category);
            }

            film.Casts = new List<Cast>();
            foreach (int castId in selectedCast)
            {
                Cast cast = db.Casts.Where(c => c.Id == castId).FirstOrDefault();
                film.Casts.Add(cast);
            }

            db.Films.Add(film);
            db.SaveChanges();
        }

        public void Update(Film film, Film formData, List<int>? selectedCategory, List<int>? selectedCast)
        {
            if (selectedCast == null)
            {
                selectedCast = new List<int>();
            }

            if (selectedCategory == null)
            {
                selectedCategory = new List<int>();
            }

            film.Title = formData.Title;
            film.Description = formData.Description;
            film.Date = formData.Date;
            film.Author = formData.Author;
            film.Duration = formData.Duration;
            film.Image = formData.Image;

            film.Categories.Clear();

            foreach(int categoryId in selectedCategory)
            {
                Category category = db.Categories.Where(c => c.Id == categoryId).FirstOrDefault();
                film.Categories.Add(category);
            }

            db.SaveChanges();

            film.Casts.Clear();

            foreach (int castId in selectedCast)
            {
                Cast cast = db.Casts.Where(c => c.Id == castId).FirstOrDefault();
                film.Casts.Add(cast);
            }

            db.SaveChanges();
        }

    }
}
