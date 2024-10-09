using Microsoft.EntityFrameworkCore;

namespace correctionJ2.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr ;database=FilmsCda27");

        }

    }
}
