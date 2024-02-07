using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TypesOfLoadingEFCore.Web.Data;
using TypesOfLoadingEFCore.Web.Models;

namespace TypesOfLoadingEFCore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            //Lazy Loading
            //List<Employee> employees = _applicationDbContext.Employee.ToList();
            //IEnumerable<Employee> employees = _applicationDbContext.Employee;
            //List<Department> department = _applicationDbContext.Department.ToList();

            //int totalDeptCount = department.Count;

            //for (int i = 0; i < totalDeptCount; i++)
            //{
            //    department[i].Employees = _applicationDbContext.Employee.Where(e => e.DepartmentId == department[i].DepartmentId).ToList();
            //}

            //int totalEmpCount = employees.Count();

            //for (int i = 0; i < totalEmpCount; i++)
            //{

            //}


            //Eager Loading

            //List<Employee> listOfEmp = _applicationDbContext.Employee
            //                                                .Include(x => x.Department)
            //                                                .ToList();



            //Explict Loading
            List<Employee> listOfEmp = _applicationDbContext.Employee.ToList();

            //_applicationDbContext.Entry(listOfEmp).Reference()

            return View("helloworld", listOfEmp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
