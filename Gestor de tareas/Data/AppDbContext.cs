using Microsoft.EntityFrameworkCore;
using Gestor_de_tareas.Models;

namespace Gestor_de_tareas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskManager> Tareas { get; set; }  
    }
}
