using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            return EmployeeService.GetAllEmployees();
        }

        [HttpGet]
        public Employee GetEmployeeById(string id)
        {
            var employee = EmployeeService.GetEmployeeById(id);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }

        [HttpGet]
        public Employee GetEmployeeByName(string name)
        {
            var employee = EmployeeService.GetEmployeeByName(name);

            if (employee == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return employee;
        }

    }
}
