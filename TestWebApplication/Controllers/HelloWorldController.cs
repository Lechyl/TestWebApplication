using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get : /HelloWorld/
        public string Index()
        {
            return "default action";
        }

        //Get : /HelloWorld/Welcome/
        public string Welcome(string name,int numTimes = 1)
        {
            return $"Name = {name} numTimes = {numTimes} ";
        }
    }
}
