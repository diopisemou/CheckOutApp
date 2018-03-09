using System;
using System.Collections.Generic;
using System.Text;

namespace CheckOutApp.Models
{
    class DeliveryOption
    {
        public DeliveryOption()
        {

        }


        public DeliveryOption(string nm, int prc, string img)
        {
            Name = nm;
            Price = prc;
            ImageSource1 = img;
        }

        public string Name { get; set; }

        public int Price { get; set; }

        public string ImageSource1 { get; set; }
    }
}
