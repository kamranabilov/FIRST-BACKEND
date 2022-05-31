using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first_backend.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Detail(int id)

        {
            if(id == null)
            {
                return NotFound();
            }
            //return Content(id.ToString());
            return View();
        }
}    }
