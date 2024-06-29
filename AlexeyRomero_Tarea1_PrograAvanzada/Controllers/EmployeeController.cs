namespace AlexeyRomero_Tarea1_PrograAvanzada.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.Take(100).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine("Full name: " + employee.FirstName + " " + employee.LastName);
            }
            return View(employees);
        }
    }
}
