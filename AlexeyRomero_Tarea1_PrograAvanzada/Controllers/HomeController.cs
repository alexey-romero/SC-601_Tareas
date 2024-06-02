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
            var employees = _context.Employees.Take(10).ToList();
            foreach (var employee in employees)
            {
                Debug.WriteLine($"ID: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName}");
            }
            return View(employees);
        }

        public IActionResult Departments()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
