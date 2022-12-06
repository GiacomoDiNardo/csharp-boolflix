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
            return db.Films.Where(f => f.Id == id).Include("Category").Include("Cast").FirstOrDefault();
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

    }
}
