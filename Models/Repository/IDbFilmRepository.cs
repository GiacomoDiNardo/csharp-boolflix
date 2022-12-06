namespace csharp_boolflix.Models.Repository
{
    public interface IDbFilmRepository
    {
        List<Film> All();
        void Create(Film film, List<int> selectedCast, List<int> selectedCategories);
        Film GetById(int id);
    }
}