namespace EMS.Api.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public char? Gender { get; set; } = 'M';
        public double? Salary { get; set; }

    }
}
