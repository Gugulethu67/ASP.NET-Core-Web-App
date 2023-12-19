using Employees_DashBoard.Model;
using System.Net;
using System.Xml.Linq;

namespace Employees_DashBoard.Data
{
    public class DBInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Employee.Any())
            {
                return;
            }
            else
            {
                try
                {
                    context.Employee.AddRange(
                        new Employee
                        {
                            Name = "Thabo",
                            Address = "Turton",
                            Position = "Soccer Player",
                            YearsExperience = 1

                        },
                        new Employee
                        {
                            Name = "Thobelani",
                            Address = "Turton",
                            Position = "Student",
                            YearsExperience = 0

                        },
                        new Employee
                        {
                            Name = "Missi",
                            Address = "Maimi",
                            Position = "Soccer Player",
                            YearsExperience = 20

                        },
                        new Employee
                        {
                            Name = "Bill Gates",
                            Address = "United States",
                            Position = "CEO",
                            YearsExperience = 9

                        },
                        new Employee
                        {
                            Name = "Gugu",
                            Address = "Joburg",
                            Position = "Soccer Player",
                            YearsExperience = 1

                        },
                        new Employee
                        {
                            Name = "Sindi",
                            Address = "Durban",
                            Position = "Singer",
                            YearsExperience = 12

                        },
                        new Employee
                        {
                            Name = "Khethelo",
                            Address = "Cape Town",
                            Position = "Soccer Player",
                            YearsExperience = 15

                        }
                    );
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message, nameof(context));
                }
               
                
            }



        }
    }
}
