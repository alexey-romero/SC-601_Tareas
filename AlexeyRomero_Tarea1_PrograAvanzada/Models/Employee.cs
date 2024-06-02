namespace AlexeyRomero_Tarea1_PrograAvanzada.Models
{
    public class Employee
    {
        [Column("emp_no")]
        public int Id { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }
    }
}
