using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebApp.Controllers
{
    public class UserController:Controller
    {
        public ViewResult Profile()
        {
            //ViewResult view = new ViewResult();
            //view.ViewName = "profile";
            //return view;        

            return View();
        }

        public ActionResult Detail(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = "UserId: " + id;
            return View();
;        }
    }
}
