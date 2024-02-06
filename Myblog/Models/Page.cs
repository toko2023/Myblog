namespace Myblog.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string? ShortDescription{ get; set; }
        public string? Description { get; set; }
        public string? Slug { get; set; }
    }
}
