﻿using Microsoft.AspNetCore.Mvc;

namespace AlexeyRomero_Tarea1_PrograAvanzada.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Departments()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }
    }
}
