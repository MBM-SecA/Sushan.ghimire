using EMS.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS.Api.Data
{

    public class EMSApiContext : DbContext
    {
        public EMSApiContext(DbContextOptions<EMSApiContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}