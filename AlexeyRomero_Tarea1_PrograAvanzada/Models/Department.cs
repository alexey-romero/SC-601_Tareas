using System.ComponentModel.DataAnnotations.Schema;

namespace AlexeyRomero_Tarea1_PrograAvanzada.Models
{
    public class Department
    {
        [Column("dept_no")]
        public string? Id { get; set; }

        [Column("dept_name")]
        public string? DepartmentName { get; set; }
    }
}
