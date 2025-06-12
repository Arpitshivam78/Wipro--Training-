using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly WebApplication3Context _context;
        public EmployeesController(WebApplication3Context context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string? searchString)
        {
            // Preserve filter state
            if (searchString != null)
            {
                currentFilter = searchString;
            }
            ViewData["CurrentFilter"] = currentFilter;

            // Toggle sort parameters
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["SalarySortParm"] = sortOrder == "Salary" ? "salary_desc" : "Salary";

            // Build queryable
            var employees = _context.Employee.AsQueryable();

            // Apply search filtering
            if (!string.IsNullOrEmpty(currentFilter))
            {
                employees = employees.Where(e =>
                    e.FullName.Contains(currentFilter) ||
                    e.Department.Contains(currentFilter));
            }

            // Apply sorting
            employees = sortOrder switch
            {
                "name_desc" => employees.OrderByDescending(e => e.FullName),
                "Date" => employees.OrderBy(e => e.DateOfJoining),
                "date_desc" => employees.OrderByDescending(e => e.DateOfJoining),
                "Salary" => employees.OrderBy(e => e.Salary),
                "salary_desc" => employees.OrderByDescending(e => e.Salary),
                _ => employees.OrderBy(e => e.FullName),
            };

            // Execute and render
            var list = await employees.AsNoTracking().ToListAsync();
            return View(list);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var employee = await _context.Employee.FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null) return NotFound();

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create() => View();

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Department,Designation,Salary,DateOfJoining")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null) return NotFound();

            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Department,Designation,Salary,DateOfJoining")] Employee employee)
        {
            if (id != employee.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Employee.Any(e => e.Id == employee.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var employee = await _context.Employee.FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null) return NotFound();

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            if (employee != null)
            {
                _context.Employee.Remove(employee);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

