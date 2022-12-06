namespace csharp_boolflix.Models
{
    public class Serie : Content
    {
       
        public List<Season>? SeasonList { get; set; }

        public Serie(string title, string description, string author, DateTime date, string image)
        {
            Title = title;
            Description = description;
            Author = author;
            Date = date;
            Image = image;
        }

    }
}
