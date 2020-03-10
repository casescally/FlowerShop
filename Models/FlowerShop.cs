using System.Collections.Generic;

namespace flower_shop
{
    public class FlowerShop
    {
        public List<Rose> Roses = new List<Rose>();
        public List<Tulip> Tulips = new List<Tulip>();
        public List<Daisy> Daisies = new List<Daisy>();
        public List<Sunflower> Sunflowers = new List<Sunflower>();
        public List<Orchid> Orchids = new List<Orchid>();

        public List<IMothersDay> MakeMothersDayArrangment()
        {
            List<IMothersDay> Arrangment = new List<IMothersDay>();
            Arrangment.Add(new Rose());
            Arrangment.Add(new Rose());
            Arrangment.Add(new Rose());
            Arrangment.Add(new Tulip());
            Arrangment.Add(new Tulip());
            Arrangment.Add(new Tulip());

            return Arrangment;
        }
        public List<IBirthday> MakeBirthdayArrangment()
        {
            List<IBirthday> Arrangment = new List<IBirthday>();
            Arrangment.Add(new Daisy());
            Arrangment.Add(new Daisy());
            Arrangment.Add(new Daisy());
            Arrangment.Add(new Sunflower());
            Arrangment.Add(new Sunflower());
            Arrangment.Add(new Sunflower());

            return Arrangment;
        }

        public List<IGetWell> MakeGetWellArrangment()
        {
            List<IGetWell> Arrangment = new List<IGetWell>();
            Arrangment.Add(new Orchid());
            Arrangment.Add(new Orchid());
            Arrangment.Add(new Orchid());

            return Arrangment;
        }
    }
}