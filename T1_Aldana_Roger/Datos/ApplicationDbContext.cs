using Microsoft.EntityFrameworkCore;
using T1_Aldana_Roger.Models;

namespace T1_Aldana_Roger.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}