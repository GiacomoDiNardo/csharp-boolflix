namespace csharp_boolflix.Models.Repository
{
    public interface IDbFilmRepository
    {
        List<Film> All();
        void Create(Film film, List<int> selectedCast, List<int> selectedCategories);
        Film GetById(int id);
        void Update(Film film, Film formData, List<int>? selectedCategory, List<int>? selectedCast);
        void Delete(Film film);
    }
}