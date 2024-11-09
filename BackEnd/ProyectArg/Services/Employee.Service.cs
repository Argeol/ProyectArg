using Microsoft.EntityFrameworkCore;
using ProyectArg.Models;
using System.Collections.Generic;

namespace ProyectArg.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void RegisterEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}
