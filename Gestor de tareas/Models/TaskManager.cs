using System.ComponentModel.DataAnnotations;

namespace Gestor_de_tareas.Models
{
    public class TaskManager
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool Completed { get; set; } = false;

    }
}
