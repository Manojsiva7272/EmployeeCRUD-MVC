using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models;

public class Employee
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    [Display(Name = "Full Name")]
    public string FullName { get; set; } = string.Empty;

    [Required, EmailAddress, StringLength(150)]
    public string Email { get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string Department { get; set; } = string.Empty;

    [Required, StringLength(100)]
    public string Designation { get; set; } = string.Empty;

    [Required]
    [Range(0, 10000000)]
    [Display(Name = "Monthly Salary")]
    public decimal Salary { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Joining Date")]
    public DateTime JoiningDate { get; set; } = DateTime.Today;
}