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

        public IActionResult Employees(int? page)
        {
            int pageSize = 10; // Number of records per page
            int pageNumber = page ?? 1; // Default to page 1 if no page is specified

            var employees = _context.Employees.OrderBy(e => e.Id).ToPagedList(pageNumber, pageSize);
            foreach (var employee in employees)
            {
                Console.WriteLine("Full name: " + employee.FirstName + " " + employee.LastName);
            }
            return View(employees);
        }

        public IActionResult Departments()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
