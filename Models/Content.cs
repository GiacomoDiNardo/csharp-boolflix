using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public abstract class Content
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(150, ErrorMessage = "Il Titolo non può avere più di 150 caratteri")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(150, ErrorMessage = "La Descrizione non può avere più di 150 caratteri")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(150, ErrorMessage = "Il Nome del regista non può avere più di 50 caratteri")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Image { get; set; }

        public List<Category>? Categories { get; set; }

        public List<Cast>? Casts { get; set; }

    }
}
