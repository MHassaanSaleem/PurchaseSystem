using Microsoft.AspNetCore.Mvc;
using PurchaseSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseSystem.Controllers
{
    public class ItemController : Controller
    {
        public readonly ConnectionStringClass connectionStringClass;
        public ItemController(ConnectionStringClass cs)
        {
            this.connectionStringClass = cs;
        }

        public IActionResult Display()
        {
            IList<Item> list = connectionStringClass.items.OrderByDescending(
                x => x.item_id).ToList();
            return View(list);
        }

        [HttpGet] // Get used for retreiving information
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //post used for submitting any data. 
        public IActionResult Create(Item obj_item)
        {
            if (obj_item != null)
            {
                connectionStringClass.items.Add(obj_item);
                connectionStringClass.SaveChanges();
                return RedirectToAction("Display");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Item item = connectionStringClass.items.Where(
                x => x.item_id == id).SingleOrDefault();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Item obj_item)
        {
            Item item = connectionStringClass.items.Where(
                x => x.item_id == obj_item.item_id).SingleOrDefault();

            item.item_name = obj_item.item_name;
            item.item_status = obj_item.item_status;
            connectionStringClass.SaveChanges();
            return RedirectToAction("Display");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Item item = connectionStringClass.items.Where(
                x => x.item_id == id).SingleOrDefault();
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Item obj_item)
        {
            Item item = connectionStringClass.items.Where(
                 x => x.item_id == obj_item.item_id).SingleOrDefault();
            connectionStringClass.items.Remove(item);
            connectionStringClass.SaveChanges();
            return View("Display");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Item item = connectionStringClass.items.Where(
                x => x.item_id == id).FirstOrDefault();
            return View(item);
        }


    }
}
