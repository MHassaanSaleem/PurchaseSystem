using Microsoft.AspNetCore.Mvc;
using PurchaseSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rotativa.AspNetCore;

namespace PurchaseSystem.Controllers
{
    public class ReportController : Controller
    {
        private readonly ConnectionStringClass connectionStringClass;
        public IList<Item> _items;
        public IList<Purchase> _purchases;
        public IList<Issuance> _issuances;

        public ReportController(ConnectionStringClass cs)
        {
            connectionStringClass = cs;
        }


        // *****************************************************
        [HttpGet]
        public IActionResult ItemData()
        {
            _items = connectionStringClass.items.OrderBy(x => x.item_id).ToList();
            return View(_items);
        }

        [HttpGet]
        public IActionResult PurchaseReport()
        {
            _purchases = connectionStringClass.purchases.OrderBy(x => x.purchase_id).ToList();
            return View(_purchases);
        }

        [HttpGet]
        public IActionResult IssuanceReport()
        {
            _issuances = connectionStringClass.issuances.OrderBy(x => x.issuance_id).ToList();
            return View(_issuances);
        }

        // *****************************************************




        [HttpPost]
        public IActionResult SearchItem(string Data)
        {
            DataClass dt_class = new DataClass(connectionStringClass);
            _items = dt_class.getItemData(Data);
            TempData["Data"] = Data;
            return View(_items);
        }

        [HttpPost]
        public IActionResult SearchPurchase(string Data)
        {
            DataClass dt_class = new DataClass(connectionStringClass);
            _purchases = dt_class.getPurchaseData(Data);
            TempData["Data"] = Data;
            return View(_purchases);
        }

        [HttpPost]
        public IActionResult SearchIssuance(string Data)
        {
            DataClass dt_class = new DataClass(connectionStringClass);
            _issuances = dt_class.getIssuanceData(Data);
            TempData["Data"] = Data;
            return View(_issuances);
        }

        // *****************************************************



        [HttpGet]
        public IActionResult ItemReportPDF()
        {
            DataClass dt_class = new DataClass(connectionStringClass);
            var myData = TempData["Data"];
            IList<Item> searchItems = dt_class.getItemData(myData.ToString());
            return new ViewAsPdf(searchItems);
        }

        [HttpGet]
        public IActionResult PurchaseReportPDF()
        {
            DataClass dt_class = new DataClass(connectionStringClass);
            var myList = TempData["Data"];
            IList<Purchase> pList = dt_class.getPurchaseData(myList.ToString());
            return new ViewAsPdf(pList);
        }

        [HttpGet]
        public IActionResult IssuanceReportPDF()
        {
            DataClass dt_class = new DataClass(connectionStringClass);
            var myList = TempData["Data"];
            IList<Issuance> pList = dt_class.getIssuanceData(myList.ToString());
            return new ViewAsPdf(pList);
        }


        // *****************************************************


        [HttpGet]
        public IActionResult AllPurchaseReportPDF()
        {
            IList<Purchase> _purchases = connectionStringClass.purchases.OrderBy(x => x.purchase_id).ToList();
            return new ViewAsPdf(_purchases);
        }

        [HttpGet]
        public IActionResult AllItemsReportPDF()
        {
            IList<Item> searchItems = connectionStringClass.items.OrderBy(x => x.item_id).ToList();
            return new ViewAsPdf(searchItems);
        }

        [HttpGet]
        public IActionResult AllIssuanceReportPDF()
        {
            IList<Issuance> searchItems = connectionStringClass.issuances.OrderBy(x => x.issuance_id).ToList();
            return new ViewAsPdf(searchItems);
        }

        // *****************************************************

    }
}
