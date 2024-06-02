namespace AlexeyRomero_Tarea1_PrograAvanzada.Controllers
{
    public class EmployeeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            //if (employees.Any())
            //{
            //    Debug.WriteLine("Number of entities retrieved: " + employees.Count);
            //    foreach (var entity in employees)
            //    {
            //        Debug.WriteLine("Entity ID: " + entity.Id + ", Name: " + entity.FirstName + ", LastName: " + entity.LastName);
            //    }
            //}
            //else
            //{
            //    Debug.WriteLine("NONE FOUND.");
            //}
            return View(employees);
            //return View();
        }
    }
}
