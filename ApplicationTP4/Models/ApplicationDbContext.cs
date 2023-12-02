using ApplicationTP4.Models;

using Microsoft.EntityFrameworkCore;
namespace ApplicationTP4_.Models
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Membershiptypes> Membershiptypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Membershiptypes>()
                .HasMany(m => m.Customers)
                .WithOne(c => c.Membershiptypes)
                .HasForeignKey(c => c.MembershiptypesId)
                .IsRequired(false);

            modelBuilder.Entity<Genres>()
                .HasMany(g => g.Movies)
                .WithOne(m => m.Genres)
                .HasForeignKey(m => m.genres_Id)
                .IsRequired(false);


            modelBuilder.Entity<Movies>()
                .HasMany(m => m.Customers)
                .WithMany(c => c.Movies);



           
        }


    }


}
