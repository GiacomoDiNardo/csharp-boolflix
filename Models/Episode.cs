namespace csharp_boolflix.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public int Duration { get; set; }

        public Season Season { get; set; }

    }
}
