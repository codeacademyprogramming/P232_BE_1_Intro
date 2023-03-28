using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace FirstWebApp.Controllers
{
    public class ProductController:Controller
    {
        //public ContentResult GetInfo()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Product info";
        //    return result;
        //}

        //public JsonResult GetInfo()
        //{
        //    JsonResult result = new JsonResult(new { Name = "Iphone", Price = 45 });
        //    return result;
        //}

        public ViewResult Detail()
        {
            //ViewResult result = new ViewResult();
            //result.ViewName = "detail";
            //return result;

            return View();
        }

        //public ContentResult GetInfo(string brand,string category,decimal price)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Product info - brand: " + brand + " - category: " + category+" - price:"+price;
        //    return result;
        //}

        public JsonResult GetInfo(string brand,string category,decimal price)
        {
            //JsonResult result = new JsonResult(new { brand = brand, category = category,salePrice=price });
            //return result;

            return Json(new { brand = brand, category = category, salePrice = price });
        }
    }
}
