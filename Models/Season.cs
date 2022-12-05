namespace csharp_boolflix.Models
{
    public class Season
    {
        public int Id { get; set; }
        public int SeasonNumber { get; set; }

        public Serie Serie { get; set; }
        public List<Episode>? EpisodeList { get; set; }
    }
}
