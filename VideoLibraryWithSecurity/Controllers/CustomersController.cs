using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using VideoLibraryWithSecurity.Models;

namespace VideoLibraryWithSecurity.Controllers
{

    public class CustomersController : Controller
    {
        // GET: Customers
        //this will get all customers from repo
        public ActionResult Index()
        {
            //create a new controller per table / model
            var customers = GetCustomers();

            return View(customers);
        }

        //this will display details of a selected customer
        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customers == null)
                return HttpNotFound();

            return View(customers);
        }


        private static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() {Id = 1, Name = "Simon"},
                new Customer() {Id = 2, Name = "Dave"},
                new Customer() {Id = 3, Name = "Mark"},
                new Customer() {Id = 4, Name = "John"},
                new Customer() {Id = 5, Name = "Jane"},
                new Customer() {Id = 6, Name = "Clair"},
            };
        }
    }
}