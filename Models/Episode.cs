using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Episode
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public int EpisodeNumber { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(150, ErrorMessage = "Il Titolo episodio non può avere più di 150 caratteri")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(150, ErrorMessage = "La Descrizione non può avere più di 150 caratteri")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public int Duration { get; set; }


        public int SeasonId { get; set; }
        public Season? Season { get; set; }

    }
}
