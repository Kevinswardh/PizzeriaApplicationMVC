using Microsoft.EntityFrameworkCore;
using PizzeriaApplicationMVC.Models;

namespace PizzeriaApplicationMVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
       public DbSet<PizzaKlass1> PizzaKlass1s { get; set; }




    }
}
