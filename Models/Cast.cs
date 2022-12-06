using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Cast
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il Nome non può avere più di 50 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il cognome non può avere più di 50 caratteri")]
        public string Surname { get; set; }
        public List<Content>? Contents { get; set; }
    }
}
