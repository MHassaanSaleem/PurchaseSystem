using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseSystem.Models
{
    public class Issuance
    {
        [Key]
        public int issuance_id { get; set; }
        public DateTime issuance_date { get; set; }
        public string emp_name { get; set; }
        public int quantity { get; set; }
    }
}
