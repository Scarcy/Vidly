using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        [Route("customers")]
        public ActionResult Customers()
        {
            var customers = GetCustomers();
            
            return View(customers);
        }
        
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().Find(c => c.Id == id);
            if(customer == null)
                return HttpNotFound();
            return View(customer);
            
        }
        
        private List<Customer> GetCustomers()
        {
            return new List<Customer> {
                new Customer { Name = "John Smith", Id = 1},
                new Customer { Name = "Mary Williams", Id = 2}
            };
        }
    }
}