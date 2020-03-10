using flower_shop;

namespace flower_shop
{
    public class Orchid : IGetWell
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public string Water_schedule { get; set; }
        public bool Thorny { get; set; }
        public bool Fragrant { get; set; }
        public double StemLength { get; set; }

    }
}