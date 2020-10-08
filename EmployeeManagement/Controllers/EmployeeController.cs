using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {


        //Object Initializer Syntax
        Person emp1 = new Person() { FirstName = "Sushan", Surname = "Ghimire", Address = "Lagankhel", Salary = 20000.0 };
        Person emp2 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp3 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp4 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp5 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp6 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp7 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp8 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };

        List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8};

        return View(employees);
    }
}

