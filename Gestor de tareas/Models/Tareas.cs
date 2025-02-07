using System.ComponentModel.DataAnnotations;

namespace Gestor_de_tareas.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public bool Completed { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
