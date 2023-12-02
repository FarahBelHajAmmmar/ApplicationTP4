using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ApplicationTP4.Models
{
  
        public class Movies
        {
            public int Id { get; set; }
            public String? Name { get; set; }
            
      
            //cle 
            public int? genres_Id { get; set; }


            //proprite de naviagation
            public ICollection<Customers>? Customers { get; set; }
            public Genres ?Genres { get; set; }

        }
    }

