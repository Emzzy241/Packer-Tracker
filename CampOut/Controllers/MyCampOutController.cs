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
        [HttpPost("/mycampout/{Id}/items")]
        public ActionResult Create(int myCampOutId, string itemName)
        {
            // A dictionary is needed. This dictionary has key(string) and value(object)
            Dictionary<string, object> model = new Dictionary<string, object>(){};
            MyCampOut foundObj = MyCampOut.FindObj(myCampOutId);
            Item newItemObj = new Item(itemName);
            foundObj.AddItem(newItemObj);
            List<Item> myCampOutItems = foundObj.ItemsList;
            model.Add("items", myCampOutItems);
            model.Add("category", foundObj);
            return View("Show", model);
        }

        // For showing each destination
        [HttpGet("/mycampout/{Id}")]
        public ActionResult Show(int id)
        {
            // We're doing something new here. Because this page will display both a Category and all Item objects saved within that Category, we must pass two types of objects to the view. However, View() can only accept one model argument. To work around this, we do the following:
            // Create a new Dictionary called model because a Dictionary can hold multiple key-value pairs.
            // Add both the Category and its associated Items to this Dictionary. These will be stored with the keys "category" and "items".
            // The Dictionary, which is named model, will be passed into View().

            Dictionary<string, object> model = new Dictionary<string, object>(){};
            MyCampOut selectedObj = MyCampOut.FindObj(id);
            List<Item> myCampOutItems = selectedObj.ItemsList;
            model.Add("myCampOut", selectedObj);
            model.Add("items", myCampOutItems);
            return View(model);
        }


    }
}