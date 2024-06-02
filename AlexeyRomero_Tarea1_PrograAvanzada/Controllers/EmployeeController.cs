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
            var employees = _context.Employees.Take(10).ToList();
            return View(employees);
        }
    }
}
