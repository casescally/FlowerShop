using System;
using System.Collections.Generic;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose redRose = new Rose();
            Sunflower yellowSunflower = new Sunflower();
            Daisy whiteDaisy = new Daisy();
            Tulip orangeTulip = new Tulip();

            FlowerShop MacsFlowerShop = new FlowerShop();
            List<IBirthday> Arrangment = MacsFlowerShop.MakeBirthdayArrangment();
        }
    }
}