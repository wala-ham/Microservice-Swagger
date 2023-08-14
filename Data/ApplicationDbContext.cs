using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using testswagger.Domain.Models;

namespace testswagger.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Parcour> Parcourslist { get; set; }
    }
}
