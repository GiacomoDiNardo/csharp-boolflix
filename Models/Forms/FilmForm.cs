using Microsoft.AspNetCore.Mvc.Rendering;

namespace csharp_boolflix.Models.Forms
{
    public class FilmForm
    {
        public Film Film { get; set; }

        public List<SelectListItem>? Categories { get; set; }
        public List<int>? SelectedCategory { get; set; }
        public List<SelectListItem>? Casts { get; set; }
        public List<int>? SelectedCast { get; set; }
    }
}
