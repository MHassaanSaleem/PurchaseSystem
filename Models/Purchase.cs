using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseSystem.Models
{
    public class Purchase
    {
        [Key]
        public int purchase_id { get; set; }
        public string purchase_item { get; set; }
        public int purchase_quantity { get; set; }
        public DateTime purchase_date { get; set; }
        public int price { get; set; }
        public string vendor { get; set; }
    }
}
