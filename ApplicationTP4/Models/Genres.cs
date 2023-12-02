namespace ApplicationTP4.Models
{
    public class Genres
    {
        public int Id { get; set; }
        public String? GenreName { get; set; }
        //propriete de naviagtion
        public ICollection<Movies> ?Movies { get; set; }
    }
}
