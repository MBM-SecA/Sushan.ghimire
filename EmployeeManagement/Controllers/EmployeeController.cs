using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        List<Person> employees = Person.GetPerson();

        return View(employees);
    }

    public ActionResult Detail(string firstName)
    {
        List<Person> employees = Person.GetPerson();
        //Person p = null;
        foreach(var employee in employees)
        {
            if(employee.FirstName == firstName)
            {
                return View(employee);
            }
        }
        return View();
    }
}

