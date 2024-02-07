using TypesOfLoadingEFCore.Web.Models;

namespace TypesOfLoadingEFCore.Web.Data
{
    public static class SeedEmployeeData
    {
        public static IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new()
                {
                    Id = 1,
                    FirstName = "Mike",
                    Email = "mike@gmail.com",
                    Gender = Gender.Male,
                    LastName = "Simson",
                    Phone = "+231778123123",
                    DepartmentId = 1,
                    Salary = 10000
                },
                new()
                {
                    Id = 2,
                    FirstName = "Alexa",
                    Email = "alexa@gmail.com",
                    Gender = Gender.Female,
                    LastName = "Smith",
                    Phone = "+231770333223",
                    DepartmentId = 1,
                    Salary = 9000
                },

                new()
                {
                    Id = 3,
                    FirstName = "Sam",
                    Email = "sam@outlook.com",
                    Gender = Gender.Male,
                    LastName = "Smith",
                    Phone = "+231770125473",
                    DepartmentId = 3,
                    Salary = 5000
                },

                new()
                {
                    Id = 4,
                    FirstName = "Dad",
                    Email = "dadwonkulah@tuseTheProgrammer.com",
                    Gender = Gender.Male,
                    LastName = "Wonkulah",
                    Phone = "+231775060775",
                    Salary = 450000,
                    DepartmentId = 4
                },
            };
        }
        public static IEnumerable<Department> GetDepartments()
        {
            return new List<Department>()
            {
               new(){DepartmentName = "Information Technology", DepartmentId = 1,
               DepartmentDescription = "Responsible for the over all IT running in the company."},

               new(){DepartmentName = "Finance", DepartmentId = 2,
               DepartmentDescription = "Responsible for the over all Finance in the department."},

               new(){DepartmentName = "Sales", DepartmentId = 3,
               DepartmentDescription = "Responsible for the sales in the department."},

                new(){DepartmentName = "Managers", DepartmentId = 4,
               DepartmentDescription = "Responsible for managing the company goals and agenda."}
            };

        }

    }
}
