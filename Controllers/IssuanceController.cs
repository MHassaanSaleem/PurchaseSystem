using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseSystem.Models;

namespace PurchaseSystem.Controllers
{
    public class IssuanceController : Controller
    {
        private readonly ConnectionStringClass connectionStringClass;

        public IssuanceController(ConnectionStringClass cs)
        {
            this.connectionStringClass = cs;
        }


        public IActionResult Display()
        {
            IList<Issuance> list = connectionStringClass.issuances.OrderByDescending(
                x => x.issuance_id).ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Issuance obj)
        {
            if (obj != null)
            {
                connectionStringClass.issuances.Add(obj);
                connectionStringClass.SaveChanges();
                return RedirectToAction("Display");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Issuance issuance = connectionStringClass.issuances.Where(
                x => x.issuance_id == id).SingleOrDefault();
            return View(issuance);
        }

        [HttpPost]
        public IActionResult Edit(Issuance obj)
        {
            Issuance issuance = connectionStringClass.issuances.Where(
                x => x.issuance_id == obj.issuance_id).SingleOrDefault();

            issuance.issuance_date = obj.issuance_date;
            issuance.emp_name = obj.emp_name;
            issuance.quantity = obj.quantity;
            connectionStringClass.SaveChanges();
            return RedirectToAction("Display");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Issuance issuance = connectionStringClass.issuances.Where(
                x => x.issuance_id == id).SingleOrDefault();
            return View(issuance);
        }

        [HttpPost]
        public IActionResult Delete(Issuance obj)
        {
            Issuance issuance = connectionStringClass.issuances.Where(
                 x => x.issuance_id == obj.issuance_id).SingleOrDefault();
            connectionStringClass.issuances.Remove(issuance);
            connectionStringClass.SaveChanges();
            return View("Display");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Issuance issuance = connectionStringClass.issuances.Where(
                x => x.issuance_id == id).FirstOrDefault();
            return View(issuance);
        }



    }
}
