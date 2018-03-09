using System;
using System.Collections.Generic;
using System.Text;

namespace CheckOutApp.Models
{
    class ShopItem
    {
        public ShopItem()
        {
            CloseImageSource = "close.png";
        }


        public ShopItem(string nm, int prc, string img,string sts,string itemid)
        {
            Name = nm;
            Price = prc;
            ImageSource1 = img;
            Status = sts;
            CloseImageSource = "close.png";
            ProductUid = "prod" + itemid;
        }

        public string Name { get; set; }

        public int Price { get; set; }

        public string ImageSource1 { get; set; }

        public string CloseImageSource { get; set; }

        public string ProductUid { get; set; }

        public string Status { get; set; }
    }
}
