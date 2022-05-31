using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace first_backend.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "HomePage";
            return view;
        }

        public ViewResult About()
        {
            return new ViewResult { ViewName = "About" };
        }

        public ActionResult FAQ()
        {
            return View();
        }
        

    }
}
