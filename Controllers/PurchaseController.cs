using Microsoft.AspNetCore.Mvc;
using PurchaseSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseSystem.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly ConnectionStringClass connectionStringClass;

        public PurchaseController(ConnectionStringClass cs)
        {
            this.connectionStringClass = cs;
        }

        [HttpGet]
        public IActionResult Display()
        {
            IList<Purchase> purchases = connectionStringClass.purchases.OrderByDescending(
                x => x.purchase_id).ToList();
            return View(purchases);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Purchase purchase)
        {
            if (purchase != null)
            {
                connectionStringClass.purchases.Add(purchase);
                connectionStringClass.SaveChanges();
                return RedirectToAction("Display");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Purchase purchase = connectionStringClass.purchases.Where(x => x.purchase_id == id).SingleOrDefault();
            return View(purchase);
        }

        [HttpPost]
        public IActionResult Edit(Purchase obj)
        {
            Purchase purchase = connectionStringClass.purchases.Where(x => x.purchase_id == obj.purchase_id).SingleOrDefault();

            purchase.purchase_item = obj.purchase_item;
            purchase.purchase_quantity = obj.purchase_quantity;
            purchase.vendor = obj.vendor;
            purchase.purchase_date = obj.purchase_date;
            purchase.price = obj.price;

            connectionStringClass.SaveChanges();
            return RedirectToAction("Display");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Purchase purchase = connectionStringClass.purchases.Where(
                x => x.purchase_id == id).SingleOrDefault();
            return View(purchase);
        }

        [HttpPost]
        public IActionResult Delete(Purchase obj)
        {
            Purchase purchase = connectionStringClass.purchases.Where(
                x => x.purchase_id == obj.purchase_id).SingleOrDefault();
            connectionStringClass.purchases.Remove(purchase);
            connectionStringClass.SaveChanges();
            return RedirectToAction("Display");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Purchase purchase = connectionStringClass.purchases.Where(
               x => x.purchase_id == id).SingleOrDefault();
            return View(purchase);
        }

    }
}
