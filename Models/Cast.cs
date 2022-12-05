namespace csharp_boolflix.Models
{
    public class Cast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Content Content { get; set; }
    }
}
