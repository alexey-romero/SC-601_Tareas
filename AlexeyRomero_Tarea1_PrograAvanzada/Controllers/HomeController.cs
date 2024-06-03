using AlexeyRomero_Tarea1_PrograAvanzada.Models;

namespace AlexeyRomero_Tarea1_PrograAvanzada.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Employees()
        {
            var employees = _context.Employees.Take(30).ToList();
            return View(employees);
        }

        public IActionResult Departments()
        {
            var departments = _context.Departments.Take(30).ToList();
            foreach (var department in departments)
            {
                Debug.WriteLine($"ID: {department.Id}, Dept Name: {department.DepartmentName}");
            }
            return View(departments);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
