using Microsoft.EntityFrameworkCore;
using FlashCardApp.Models;

namespace FlashCardApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Card> Cards { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}