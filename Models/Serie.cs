namespace csharp_boolflix.Models
{
    public class Serie : Content
    {
        public int Id { get; set; }
        
        public List<Season>? SeasonList { get; set; }
        

    }
}
