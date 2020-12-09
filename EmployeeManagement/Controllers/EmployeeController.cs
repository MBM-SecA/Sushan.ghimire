using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    private readonly EMSContext db;
    public EmployeeController(EMSContext _db)
    {
        db = _db;
    }
    public ActionResult Index()
    {
        var employees = db.People.ToList();
        return View(employees);
    }

    public ActionResult Detail([FromQuery] int id)
    {
        var employee = db.People.Find(id);

        return View(employee);
    }

    [HttpGet]
    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(Person person)
    {
        db.People.Add(person);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int id)
    {
        var employee = db.People.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult Edit(Person person)
    {
        db.People.Attach(person);
        db.People.Update(person);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        var employee = db.People.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult Delete(Person person)
    {
        db.People.Attach(person);
        db.People.Remove(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}


