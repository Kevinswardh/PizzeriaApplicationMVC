using PizzeriaApplicationMVC.Models;

namespace PizzeriaApplicationMVC.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Pizza1
                if (!context.PizzaKlass1s.Any())
                {
                    context.PizzaKlass1s.AddRange(new List<PizzaKlass1>()
                    {
                        new PizzaKlass1()
                        {
                            PizzaName = "Margaritha",
                            PizzaIngre = "Tomat, Ost",
                            Price = 90
                        },
                        new PizzaKlass1()
                        {
                            PizzaName = "Vesuvio",
                            PizzaIngre = "Tomat, Ost, Skinka",
                            Price = 90
                        },
                    });
                    context.SaveChanges();
                }



                }
        }


    }
}
