using EmployeeCRUD.Data;
using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Controllers;

public class EmployeesController : Controller
{
    private readonly ApplicationDbContext _db;
    public EmployeesController(ApplicationDbContext db) => _db = db;

    // LIST
    public async Task<IActionResult> Index()
    {
        var employees = await _db.Employees.OrderByDescending(e => e.Id).ToListAsync();
        return View(employees);
    }

    // CREATE FORM
    [HttpGet]
    public IActionResult Create() => View(new Employee());

    // CREATE SAVE
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Employee employee)
    {
        if (!ModelState.IsValid) return View(employee);
        if (await _db.Employees.AnyAsync(e => e.Email == employee.Email))
        {
            ModelState.AddModelError(nameof(employee.Email), "This email already exists.");
            return View(employee);
        }
        _db.Employees.Add(employee);
        await _db.SaveChangesAsync();
        TempData["Success"] = "Employee created successfully.";
        return RedirectToAction(nameof(Index));
    }

    // EDIT FORM
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var employee = await _db.Employees.FindAsync(id);
        if (employee == null) return NotFound();
        return View(employee);
    }

    // EDIT SAVE
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Employee employee)
    {
        if (id != employee.Id) return BadRequest();
        if (!ModelState.IsValid) return View(employee);
        if (await _db.Employees.AnyAsync(e => e.Email == employee.Email && e.Id != id))
        {
            ModelState.AddModelError(nameof(employee.Email), "This email already exists.");
            return View(employee);
        }
        _db.Employees.Update(employee);
        await _db.SaveChangesAsync();
        TempData["Success"] = "Employee updated successfully.";
        return RedirectToAction(nameof(Index));
    }

    // DELETE
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        var employee = await _db.Employees.FindAsync(id);
        if (employee == null) return NotFound();
        _db.Employees.Remove(employee);
        await _db.SaveChangesAsync();
        TempData["Success"] = "Employee deleted successfully.";
        return RedirectToAction(nameof(Index));
    }
}