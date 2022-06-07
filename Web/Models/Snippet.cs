namespace Web.Models
{
    public class Snippet
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<Tag> Tags { get; set; } 
        public SnippetTipo Tipo { get; set; }
    }
}
