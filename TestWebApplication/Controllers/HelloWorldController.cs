using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebApplication.Data;

namespace TestWebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly HelloWorldContext _context;

        public HelloWorldController(HelloWorldContext context)
        {
            _context = context;
        }

        //Get : /HelloWorld/
        public IActionResult Index()
        {
            return View(_context.users.ToList());
        }

        //Get : /HelloWorld/Welcome/
        public string Welcome(string name,int ID = 1)
        {
            return $"Name = {name} numTimes = {ID} ";
        }
    }
}
