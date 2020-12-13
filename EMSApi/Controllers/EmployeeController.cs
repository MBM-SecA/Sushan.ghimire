﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly EMContext db;
        public EmployeesController(EMContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var employees = db.Employees.ToList();
            return employees;
        }

        [HttpPost]
        public int Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();

            return 1;
        }
    }
}
