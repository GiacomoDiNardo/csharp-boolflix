namespace csharp_boolflix.Models
{
    public abstract class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }

        public List<Category>? Categories { get; set; }

        public List<Cast> Casts { get; set; }

    }
}
