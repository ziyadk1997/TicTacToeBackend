using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendSample.Controllers
{
    public class ComputeController : Controller
    {
        // GET: Compute
        public string Test(string name)
        {
            return "Test Action " + name;
        }
    }
}