namespace ApplicationTP4.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        //cle 
        public int MembershiptypesId { get; set; }
        //propriete de navigation

        public Membershiptypes? Membershiptypes { get; set; }
        public ICollection<Movies> Movies { get; set; }


    }
}
