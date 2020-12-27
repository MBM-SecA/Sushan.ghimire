using Microsoft.AspNetCore.Mvc;
using EMS.Api.Data.Models;
using EMS.Api.Data;
using System.Linq;

namespace EMS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly EMSApiContext db;
        public EmployeesController(EMSApiContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public Employee[] Get()
        {
            var employees = db.Employees.ToArray();
            return employees;
        }

        [HttpPost]
        public int Create(Employee employee)
        {
            db.Employees.Add(employee);
            var x = db.SaveChanges();
            return x;
        }
    }
}