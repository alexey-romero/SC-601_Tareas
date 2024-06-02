namespace AlexeyRomero_Tarea1_PrograAvanzada.Services
{
    public class DatabaseConnTester
    {
        private readonly AppDbContext _context;

        public DatabaseConnTester(AppDbContext context)
        {
            _context = context;
        }

        public void TestConnection()
        {
            try
            {
                var test = _context.Employees.Take(10).ToList();
                Console.WriteLine("Database connection successful!");
                foreach (var employee in test)
                {
                    Console.WriteLine($"Id: {employee.Id}, FirstName: {employee.FirstName}, LastName: {employee.LastName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database connection failed: " + ex.Message);
            }
        }
    }
}
