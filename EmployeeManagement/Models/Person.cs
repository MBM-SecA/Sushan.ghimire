using System.Collections.Generic;

public class Person
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Person> GetPerson()
    {
        //Object Initializer Syntax
        Person emp1 = new Person() { FirstName = "Sushan", Surname = "Ghimire", Address = "Lagankhel", Salary = 20000.0 };
        Person emp2 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp3 = new Person() { FirstName = "Shyam", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp4 = new Person() { FirstName = "Rita", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp5 = new Person() { FirstName = "Rikesh", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp6 = new Person() { FirstName = "Jame", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp7 = new Person() { FirstName = "Pulu", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp8 = new Person() { FirstName = "Lala", Surname = "Bahadur", Address = "Bhaktapur", Salary = 20000.0 };

        return new List<Person> { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8 };

    }

}