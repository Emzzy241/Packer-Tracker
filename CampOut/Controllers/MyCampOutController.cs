using CampOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace CampOut.Controllers
{
    public class MyCampOutController : Controller
    {
        [HttpGet("/mycampout")]
        public ActionResult Index()
        {
            List<MyCampOut> destinationList = MyCampOut.GetAllObj();
            return View(destinationList);
        }
        [HttpGet("/mycampout/new")]
        public ActionResult New()
        {
            return View();
        }

        // A Create for new Categories
        // The power of dynamic routing, i.e same route path but different things gets shown
        [HttpPost("/mycampout")]
        public ActionResult Create(string userDestination)
        {
            MyCampOut newMyCampOut = new MyCampOut(userDestination);
            return RedirectToAction("Index");
        }

        // A different Create that creates new Items within a certain Category(MyCampOut)
        // [HttpPost("/mycampout/{Id}/items")]
        // public ActionResult Create(int myCampOutId, string itemName)
        // {
        //     // A dictionary is needed. This dictionary has key(string) and value(object)
        //     Dictionary<string, object> model = new Dictionary<string, object>(){};
        //     MyCampOut foundObj = MyCampOut.FindObj(myCampOutId);
        //    foundObj.AddItem(itemName);


        // }


    }
}