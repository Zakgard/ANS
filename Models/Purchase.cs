using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ANS_SHOP.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }

        public string BuyerID { get;set; }

        public int GameID { get; set; }

        public DateTime DateOfBuying { get; set; }
    }
}