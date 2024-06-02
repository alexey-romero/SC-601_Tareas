using System.ComponentModel.DataAnnotations.Schema;

namespace AlexeyRomero_Tarea1_PrograAvanzada.Models
{
    public class Department
    {
        [Column("dept_no")]
        public int Id { get; set; }

        [Column("dept_name")]
        public int DepartmentName { get; set; }
    }
}
