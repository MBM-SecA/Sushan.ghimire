using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }

    [Required(ErrorMessage = "I need a first name")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required, Display(Name = "Last Name")]

    public string Surname { get; set; }
    public string Address { get; set; }
    public char? Gender { get; set; } = 'M';
    public double? Salary { get; set; }

    public static List<Person> GetEmployees()
    {
        //Object Initializer Syntax
        Person emp1 = new Person() { Id = 1 ,FirstName = "Sushan", Surname = "Ghimire", Address = "Lagankhel", Salary = 20000.0 };
        Person emp2 = new Person() { Id = 2 ,FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp3 = new Person() { Id = 3 ,FirstName = "Shyam", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp4 = new Person() { Id = 4 ,FirstName = "Rita", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp5 = new Person() { Id = 5 ,FirstName = "Rikesh", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp6 = new Person() { Id = 6 ,FirstName = "Jame", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp7 = new Person() { Id = 7 ,FirstName = "Pulu", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp8 = new Person() { Id = 8 ,FirstName = "Lala", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp9 = new Person() { Id = 9 ,FirstName = "Lalita", Surname = "Kumari", Address = "Kirtipur", Salary = 20000.0, Gender = 'F' };

        return new List<Person> { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9 };

    }

}