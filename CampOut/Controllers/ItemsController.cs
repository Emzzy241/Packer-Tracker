using CampOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CampOut.Controllers
{
    // C# searches your views folder for Items and then the name of the method(New)
    // That is what we have instructed it to do with the class names ItemsController
    public class ItemsController : Controller
    {
        // [HttpGet("/mycampout/{Id}/items/")]
        // public ActionResult Index()
        // {
        //     return View();
        // }

        // The objId in curly is the same as the integer variable(objId).. 
        [HttpGet("/mycampout/{objId}/items/new")]
        public ActionResult New(int objId)
        {
            MyCampOut newCampOut = MyCampOut.FindObj(objId);
            return View(newCampOut);
        }

        // For showing each object under a certain category(MyCampOut)
        [HttpGet("/mycampout/{myCampOutId}/items/{itemId}")]
        public ActionResult Show(int myCampOutId, int itemId)
        {
            Item myItem = Item.FindItem(itemId);
            MyCampOut newObj = MyCampOut.FindObj(myCampOutId);
            Dictionary<string, object> model = new Dictionary<string, object>(){};
            model.Add("myItemKey", myItem);
            model.Add("newObjKey", newObj);
            return View(model);


        }
    
    }
}