using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(150, ErrorMessage = "Il Nome non può avere più di 150 caratteri")]
        public string Name { get; set; }
        
        public List<Content>? Contents { get; set; }
    }
}
